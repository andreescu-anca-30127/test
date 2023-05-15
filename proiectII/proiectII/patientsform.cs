using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectII
{
    public partial class patientsform : Form
    {
        SqlConnection mycon = new SqlConnection();

        public patientsform()
        {
            InitializeComponent();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\skolika\\anu3\\semestru2\\ii_laborator\\proiectII\\proiectII\\Database.mdf;Integrated Security=True";
            mycon.Open();
            mycon.Close();
        }

      
        public void RefreshDataGrid()
        {
          
            mycon.Open();
            SqlCommand reset = new SqlCommand("SELECT * FROM Patients", mycon);
            // s-a creat o instanta DataAdapter ca sa putem citii datele din baza de date 
            SqlDataAdapter mydataAdapter = new SqlDataAdapter();
            mydataAdapter.SelectCommand = reset;
            DataTable table = new DataTable();
            mydataAdapter.Fill(table);//umplem datatable cu comandat sql data
                                      //setam sursa de date de la datagrid cu cel de la datatable
            patientsDataGridView.DataSource = table;
            mycon.Close();
        }

        private void patientsform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.databaseDataSet1.Patients);

        }

        private void firstNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                // permite introducerea numai literelor
                e.Handled = true;
            }
        }

        private void lastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                // permite introducerea numai literelor
                e.Handled = true;
            }

        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar !=' ')
            {
                // daca nu este o cifra setam proprietatea handled => caracterul introdus e ingnorat
                e.Handled = true;
            }
        }

        private void birthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // sa nu avem o zi mai mare decat cea curenta
            DateTime selected = birthDateDateTimePicker.Value;
            if (selected > DateTime.Today)
            {
                MessageBox.Show("Please select a corect date");
                birthDateDateTimePicker.Value = DateTime.Today;
                return;
              
            }
           
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                //se preiau valorile din textbox

                // preluare id angajat din randul selectat de noi
                int selectedPatientId = (int)patientsDataGridView.SelectedRows[0].Cells[0].Value;
                //verificare daca firstname textbox gol
                string firstname;
                if (string.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    firstname = (string)patientsDataGridView.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    firstname = firstNameTextBox.Text;
                }
                string lastname;
                if (string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    lastname = (string)patientsDataGridView.SelectedRows[0].Cells[2].Value;
                }
                else
                {
                    lastname = lastNameTextBox.Text;
                }
                string email;
                if (string.IsNullOrEmpty(emailTextBox.Text))
                {
                    email = (string)patientsDataGridView.SelectedRows[0].Cells[3].Value;
                }
                else
                {
                    email = emailTextBox.Text;
                    SqlCommand searchEmail = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Email = @Email", mycon);
                    searchEmail.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    int countEmail = (int)searchEmail.ExecuteScalar();
                    if (countEmail > 0)
                    {
                        MessageBox.Show("This email already exist");
                        return;
                    }
                }
                 string phonenumber;
                if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
                {
                    phonenumber = (string)patientsDataGridView.SelectedRows[0].Cells[4].Value;
                }
                else
                {
                    phonenumber = phoneNumberTextBox.Text;
                    SqlCommand searchPhoneNumber = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE PhoneNumber = @PhoneNumber", mycon);
                    searchPhoneNumber.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                    int countPhoneNumber = (int)searchPhoneNumber.ExecuteScalar();
                    if (countPhoneNumber > 0)
                    {
                        MessageBox.Show("This phone number already exist");
                        return;
                    }
                }
                DateTime birthdate;
                if (string.IsNullOrEmpty(birthDateDateTimePicker.Text))
                {
                    birthdate = (DateTime)patientsDataGridView.SelectedRows[0].Cells[5].Value;
                }
                else
                {
                    birthdate = DateTime.Parse(birthDateDateTimePicker.Text);
                }


                //actualizare baze de date 
                SqlCommand cmd = new SqlCommand("UPDATE Patients SET FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber  WHERE Patient_ID = @Patient_ID", mycon);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@BirthDate", birthdate);
                cmd.Parameters.AddWithValue("@Patient_ID", selectedPatientId);

                
                cmd.ExecuteNonQuery();
                mycon.Close();
                RefreshDataGrid();
                MessageBox.Show("Successfully updated");
                firstNameTextBox.Text = null;
                lastNameTextBox.Text = null;
                emailTextBox.Text = null;
                phoneNumberTextBox.Text = null;
                birthDateDateTimePicker.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                int selectedPatientId = (int)patientsDataGridView.SelectedRows[0].Cells[0].Value; //sterge
                patientsDataGridView.Rows.RemoveAt(patientsDataGridView.SelectedRows[0].Index);
                //comanda sql de stergere din baza de date 
                SqlCommand cmd = new SqlCommand("Delete FROM Patients WHERE Patient_ID = @Patient_ID", mycon);
                cmd.Parameters.AddWithValue("@Patient_Id", selectedPatientId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {

            try
            {
                mycon.Open();
                //sa nu se poata introduca acelasi email
                SqlCommand searchEmail = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE Email = @Email", mycon);
                searchEmail.Parameters.AddWithValue("@Email", emailTextBox.Text);
                int countEmail = (int)searchEmail.ExecuteScalar();
                //sa nu se poata sa avem acelasi numar de telefon
                SqlCommand searchPhoneNumber = new SqlCommand("SELECT COUNT(*) FROM Patients WHERE PhoneNumber = @PhoneNumber", mycon);
                searchPhoneNumber.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                int countPhoneNumber = (int)searchPhoneNumber.ExecuteScalar();
            bool access = true;
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                access = false;
                MessageBox.Show("First Name field is required");
                return;

            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                access = false;
                MessageBox.Show("Last name field is required");
                return;
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                access = false;
                MessageBox.Show("Email field is required");
                return;
            }
            if(countEmail > 0)
            {
                access = false;
                MessageBox.Show("This email already exist");
                return;
            }
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                access = false;
                MessageBox.Show("Phone number field is required");
                return;
            }
            if(countPhoneNumber > 0)
            {
                access = false;
                MessageBox.Show("This phone number already exist");
                return;
            }
            if (access)
            {
                SqlCommand cmd = new SqlCommand(" INSERT INTO Patients values ( @FirstName, @LastName, @Email, @PhoneNumber, @BirthDate)  ", mycon);

                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber",phoneNumberTextBox.Text);
                cmd.Parameters.AddWithValue("@BirthDate",  DateTime.Parse( birthDateDateTimePicker.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                firstNameTextBox.Text = null;
                lastNameTextBox.Text = null;
                emailTextBox.Text = null;
                phoneNumberTextBox.Text = null;
                birthDateDateTimePicker.Value = DateTime.Today ;
                mycon.Close();
                RefreshDataGrid();
        
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
    }

