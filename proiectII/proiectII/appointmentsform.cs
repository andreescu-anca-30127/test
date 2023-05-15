using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectII
{
    public partial class appointmentsform : Form
    {
        SqlConnection mycon =new SqlConnection();
        public appointmentsform()
        {
            InitializeComponent();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\skolika\\anu3\\semestru2\\ii_laborator\\proiectII\\proiectII\\Database.mdf;Integrated Security=True";
            mycon.Open();
            mycon.Close();

        }


        public void RefreshDataGrid()
        {
            // actualizare datagrid
            //coomanda sql pentru a selectat tot din tabelul doctori
            mycon.Open();
            SqlCommand reset = new SqlCommand("SELECT * FROM Appointments", mycon);
            // s-a creat o instanta DataAdapter ca sa putem citii datele din baza de date 
            SqlDataAdapter mydataAdapter = new SqlDataAdapter();
            mydataAdapter.SelectCommand = reset;
            DataTable table = new DataTable();
            mydataAdapter.Fill(table);//umplem datatable cu comandat sql data
                                      //setam sursa de date de la datagrid cu cel de la datatable
            appointmentsDataGridView.DataSource = table;
            mycon.Close();
        }

        private void appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet1);

        }

        private void appointmentsform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.databaseDataSet1.Appointments);
            appointmentDateTimePicker.Value = DateTime.Now.AddHours(1);

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                int selectedAppointmentId = (int)appointmentsDataGridView.SelectedRows[0].Cells[0].Value; //sterge
                appointmentsDataGridView.Rows.RemoveAt(appointmentsDataGridView.SelectedRows[0].Index);
                //comanda sql de stergere din baza de date 
                SqlCommand cmd = new SqlCommand("Delete FROM APPOINTMENTS WHERE Appointment_ID = @Appointment_ID", mycon);
                cmd.Parameters.AddWithValue("@Appointment_ID", selectedAppointmentId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void patient_IDTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // daca nu este o cifra setam proprietatea handled => caracterul introdus e ingnorat
                e.Handled = true;
            }

        }

        private void doctor_IDTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // daca nu este o cifra setam proprietatea handled => caracterul introdus e ingnorat
                e.Handled = true;
            }

        }

        private void employee_IDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                // daca nu este o cifra setam proprietatea handled => caracterul introdus e ingnorat
                e.Handled = true;
            }

        }

        private void appointmentDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDateTime = DateTime.Parse(appointmentDateTimePicker.Text);
            if (selectedDateTime < DateTime.Now)
            {
                //trebuie selectata o data mai mare decat cea curenta
                MessageBox.Show("Please choose a di");
                appointmentDateTimePicker.Value = DateTime.Now.AddHours(1);
                return;
            }
                //setam ora minima ora 8 si ora maxima 19
                if (selectedDateTime.Hour < 8 || selectedDateTime.Hour >= 19)
                {
                    MessageBox.Show("Please choose a different time! Appoitments can only be scheduled between 08:00 and 19:00.");
                    return;
                }
               
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            bool access = true;
            mycon.Open();
            //verificam daca exista patient_ID
            SqlCommand search = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Patient_ID = @Patient_ID", mycon);
            search.Parameters.AddWithValue("@Patient_ID", int.Parse(patient_IDTextBox.Text));
            int searchPatient = (int)search.ExecuteScalar();

            //verificam daca exista doctor_ID
            SqlCommand searchdoctor = new SqlCommand("SELECT COUNT(*) FROM Doctors WHERE Doctor_ID = @Doctor_ID", mycon);
            searchdoctor.Parameters.AddWithValue("@Doctor_ID", int.Parse(doctor_IDTextBox.Text));
            int countdoctor = (int)searchdoctor.ExecuteScalar();

            //verificam daca exista employee_ID
            SqlCommand searchemployee = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Employee_ID = @Employee_ID", mycon);
            searchemployee.Parameters.AddWithValue("@Employee_ID", int.Parse(employee_IDTextBox.Text));
            int countemployee = (int)searchemployee.ExecuteScalar();
            // verificam daca exista o porgramare la aceeasi ora la acelasi doctor
            SqlCommand searchappointment = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE Doctor_ID = @Doctor_ID AND AppointmentDateTime = @AppointmentDateTime", mycon);
            searchappointment.Parameters.AddWithValue("@Doctor_ID", int.Parse(doctor_IDTextBox.Text));
            searchappointment.Parameters.AddWithValue("@AppointmentDateTime", DateTime.Parse(appointmentDateTimePicker.Text));
            int countappointment = (int)searchappointment.ExecuteScalar();

            //verficare daca exisat in baza de date 
            if (searchPatient == 0)
            {
                access = false;
                MessageBox.Show("Patient ID not found");
                return;
            }
            if (countdoctor == 0)
            {
                access = false;
                MessageBox.Show("Doctor ID not found");
                return;
            }
            if (countemployee == 0)
            {
                access = false;
                MessageBox.Show("Employee ID not found");
                return;

            }
            //verificare existenta toate datele
            if (string.IsNullOrEmpty(patient_IDTextBox.Text))
            {
                access = false;
                MessageBox.Show("Patient ID  field is required");
                return;

            }
            if (string.IsNullOrEmpty(doctor_IDTextBox.Text))
            {
                access = false;
                MessageBox.Show("Doctor ID  field is required");
                return;
            }
            if (string.IsNullOrEmpty(employee_IDTextBox.Text))
            {
                access = false;
                MessageBox.Show("Employee ID is required");
                return;
            } 
            if (countappointment > 0)
            {
                access = false;
                MessageBox.Show("There is already an appointment at the same time for this doctor");
                return;
            }
            if (string.IsNullOrEmpty(descriptionTextBox.Text))
            {
                access = false;
                MessageBox.Show("Description field is required");
                return;
            }

            if (access)
            {
               
                SqlCommand cmd = new SqlCommand(" INSERT INTO Appointments values ( @Patient_ID, @Doctor_ID, @Employee_ID, @AppointmentDateTime, @Description)  ", mycon);

                cmd.Parameters.AddWithValue("@Patient_ID", int.Parse(patient_IDTextBox.Text));
                cmd.Parameters.AddWithValue("@Doctor_ID", int.Parse(doctor_IDTextBox.Text));
                cmd.Parameters.AddWithValue("@Employee_ID", int.Parse(employee_IDTextBox.Text));
                cmd.Parameters.AddWithValue("@AppointmentDateTime", DateTime.Parse(appointmentDateTimePicker.Text));
                cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");

                // Email
                SqlCommand email = new SqlCommand("Select Email FROM Patients Where Patient_ID = @Patient_ID", mycon);
                email.Parameters.AddWithValue("@Patient_ID", int.Parse(patient_IDTextBox.Text));
                string searchemail = (string)email.ExecuteScalar();
                MailMessage mail = new MailMessage();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("test.proiectII@gmail.com");
                mail.To.Add(searchemail);
                mail.Subject = "You have an appoitment";
                mail.Body = "Hello! An appoitment has been scheduled at:" + " " + appointmentDateTimePicker.Text + " " + "If you are unable to come, please let us know. Have a great day!";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("test.proiectII@gmail.com", "mxjzadsaliyycdms");
                smtp.EnableSsl = true;
                 smtp.Send(mail);

                MessageBox.Show("An email has been send to:" +searchemail);

                patient_IDTextBox.Text = null;
                doctor_IDTextBox.Text = null;
                employee_IDTextBox.Text = null;
                appointmentDateTimePicker.Value = DateTime.Now;
                descriptionTextBox.Text = null;
                mycon.Close();
                RefreshDataGrid();
             
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (appointmentsDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                bool access = true;

                // preluare id angajat din randul selectat de noi
                int selectedAppointmentId = (int)appointmentsDataGridView.SelectedRows[0].Cells[0].Value;
                //verificare daca firstname textbox gol
                int patientid;
                if (string.IsNullOrEmpty(patient_IDTextBox.Text))
                {
                    patientid = (int)appointmentsDataGridView.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    patientid = int.Parse(patient_IDTextBox.Text);

                    SqlCommand search = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Patient_ID = @Patient_ID", mycon);
                    search.Parameters.AddWithValue("@Patient_ID", int.Parse(patient_IDTextBox.Text));
                    int searchPatient = (int)search.ExecuteScalar();
                    if (searchPatient == 0)
                    {
                        access = false;
                        MessageBox.Show("Patient ID not found");
                        return;
                    }
                }
                int doctorid;
                if (string.IsNullOrEmpty(doctor_IDTextBox.Text))
                {
                    doctorid = (int)appointmentsDataGridView.SelectedRows[0].Cells[2].Value;
                }
                else
                {
                    doctorid = int.Parse(doctor_IDTextBox.Text);
                    //verificam daca exista doctor_ID
                    SqlCommand searchdoctor = new SqlCommand("SELECT COUNT(*) FROM Doctors WHERE Doctor_ID = @Doctor_ID", mycon);
                    searchdoctor.Parameters.AddWithValue("@Doctor_ID", int.Parse(doctor_IDTextBox.Text));
                    int countdoctor = (int)searchdoctor.ExecuteScalar();
                    if (countdoctor == 0)
                    {
                        access = false;
                        MessageBox.Show("Doctor ID not found");
                        return;
                    }
                }
                int employeeid;
                if (string.IsNullOrEmpty(employee_IDTextBox.Text))
                {
                    employeeid = (int)appointmentsDataGridView.SelectedRows[0].Cells[3].Value;
                }
                else
                {
                    employeeid = int.Parse(employee_IDTextBox.Text);
                    //verificam daca exista employee_ID
                    SqlCommand searchemployee = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Employee_ID = @Employee_ID", mycon);
                    searchemployee.Parameters.AddWithValue("@Employee_ID", int.Parse(employee_IDTextBox.Text));
                    int countemployee = (int)searchemployee.ExecuteScalar();
                    if (countemployee == 0)
                    {
                        access = false;
                        MessageBox.Show("Employee ID not found");
                        return;

                    }
                }
                DateTime appointmentDateTime;
                if (string.IsNullOrEmpty(appointmentDateTimePicker.Text))
                {
                    appointmentDateTime = (DateTime)appointmentsDataGridView.SelectedRows[0].Cells[4].Value;
                }
                else
                {
                    appointmentDateTime = DateTime.Parse(appointmentDateTimePicker.Text);
                    SqlCommand searchappointment = new SqlCommand("SELECT COUNT(*) FROM Appointments WHERE Doctor_ID = @Doctor_ID AND AppointmentDateTime = @AppointmentDateTime", mycon);
                    searchappointment.Parameters.AddWithValue("@Doctor_ID", int.Parse(doctor_IDTextBox.Text));
                    searchappointment.Parameters.AddWithValue("@AppointmentDateTime", DateTime.Parse(appointmentDateTimePicker.Text));
                    int countappointment = (int)searchappointment.ExecuteScalar();
                    if (countappointment > 0)
                    {
                        access = false;
                        MessageBox.Show("There is already an appointment at the same time for this doctor");
                        return;
                    }

                }
                string description;
                if (string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    description = (string)appointmentsDataGridView.SelectedRows[0].Cells[5].Value;
                }
                else
                {
                    description = descriptionTextBox.Text;
                }
                if (access)
                {

                    //actualizare baze de date 
                    SqlCommand cmd = new SqlCommand("UPDATE Appointments SET Patient_ID = @Patient_ID, Doctor_ID = @Doctor_ID, Employee_ID = @Employee_ID, AppointmentDateTime = @AppointmentDateTime, Description = @Description  WHERE Appointment_ID = @Appointment_ID", mycon);
                    cmd.Parameters.AddWithValue("@Patient_ID", patientid);
                    cmd.Parameters.AddWithValue("@Doctor_ID", doctorid);
                    cmd.Parameters.AddWithValue("@Employee_ID", employeeid);
                    cmd.Parameters.AddWithValue("@AppointmentDateTime", appointmentDateTime);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Appointment_ID", selectedAppointmentId);

                    cmd.ExecuteNonQuery();
                    mycon.Close();
                    RefreshDataGrid(); 
                    MessageBox.Show("Successfully updated");
                    patient_IDTextBox.Text = null;
                    doctor_IDTextBox.Text = null;
                    employee_IDTextBox.Text = null;
                    appointmentDateTimePicker.Value = DateTime.Now;
                    descriptionTextBox.Text = null;

                }
                else
                {
                    MessageBox.Show("Please select a row to update");
                }
            }
        }
    }
}
    

    
    

