using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proiectII
{
    public partial class doctorsform : Form
    {
        SqlConnection mycon = new SqlConnection();
        public doctorsform()
        {
            InitializeComponent();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\skolika\\anu3\\semestru2\\ii_laborator\\proiectII\\proiectII\\Database.mdf;Integrated Security=True";
           

        }
        public void RefreshDataGrid()
        {
            //coomanda sql pentru a selectat tot din tabelul doctori 
            mycon.Open();
            SqlCommand reset = new SqlCommand("SELECT * FROM Doctors", mycon);
            // s-a creat o instanta DataAdapter ca sa putem citii datele din baza de date 
            SqlDataAdapter mydataAdapter = new SqlDataAdapter();
            mydataAdapter.SelectCommand = reset;
            DataTable table = new DataTable();
            mydataAdapter.Fill(table);//umplem datatable cu comandat sql data
                                      //setam sursa de date de la datagrid cu cel de la datatable
            doctorsDataGridView.DataSource = table;
            mycon.Close();
        }
        private void insertDoctorBtn_Click(object sender, EventArgs e)

        { 
            mycon.Open();
            SqlCommand searchPhoneNumber = new SqlCommand("SELECT COUNT(*) FROM Doctors WHERE PhoneNumber = @PhoneNumber", mycon);
            searchPhoneNumber.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
            int countPhoneNumber = (int)searchPhoneNumber.ExecuteScalar();
            SqlCommand search = new SqlCommand("SELECT COUNT(*) FROM Specialties Where Specialty_ID = @Specialty_ID", mycon);
            search.Parameters.AddWithValue("@Specialty_ID", int.Parse(specialtyIDTextBox.Text));
            int searchspecialty = (int)search.ExecuteScalar();
            //procedura de insert pentru un doctor nou
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
            if (string.IsNullOrEmpty(specialtyIDTextBox.Text))
            {
                access = false;
                MessageBox.Show(" Specialty Id is required");
                return;
            }

            if (searchspecialty == 0)
            {
                access = false;
                MessageBox.Show("Specialty ID not found");
                return;

            }

            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                access = false;
                MessageBox.Show("Phone number field is required");
                return;
            }
            if (countPhoneNumber > 0)
            {
                access = false;
                MessageBox.Show("This phone number already exist");
            }
            if (access)
            {
                SqlCommand cmd = new SqlCommand(" INSERT INTO Doctors values ( @FirstName, @LastName, @Specialty_ID, @PhoneNumber)  ", mycon);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Specialty_ID", int.Parse(specialtyIDTextBox.Text));
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumberTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                mycon.Close();
                RefreshDataGrid();
                firstNameTextBox.Text = null;
                lastNameTextBox.Text = null;
                phoneNumberTextBox.Text = null;
                specialtyIDTextBox.Text = null;
               
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            //procedura de delete se realizeaza numai dupa id doctorului

            if (doctorsDataGridView.SelectedRows.Count > 0)
            {
                
                mycon.Open();
                int selectedDoctorId = (int)doctorsDataGridView.SelectedRows[0].Cells[0].Value; //sterge
                doctorsDataGridView.Rows.RemoveAt(doctorsDataGridView.SelectedRows[0].Index);
                //comanda sql de stergere din baza de date 
                SqlCommand cmd = new SqlCommand("Delete FROM Doctors WHERE Doctor_ID = @Doctor_ID", mycon);
                cmd.Parameters.AddWithValue("@Doctor_Id", selectedDoctorId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Successfully deleted");

            }
            else
            {
                MessageBox.Show("Please select a row to delete");

            }
        }

        private void doctorsform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter1.Fill(this.databaseDataSet1.Doctors);


        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (doctorsDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                // preluare id doctor din randul selectat de noi
                int selectedDoctorId = (int)doctorsDataGridView.SelectedRows[0].Cells[0].Value;
                //verificare daca firstname textbox gol
                string firstname;
                if (string.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    firstname = (string)doctorsDataGridView.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    firstname=firstNameTextBox.Text;
                }
                string lastname;
                if (string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    lastname = (string)doctorsDataGridView.SelectedRows[0].Cells[2].Value;
                }
                else
                {
                    lastname = lastNameTextBox.Text;
                }
                int specialtyid;
                if (string.IsNullOrEmpty(specialtyIDTextBox.Text))
                {
                    specialtyid = (int)doctorsDataGridView.SelectedRows[0].Cells[3].Value;
                }
                else
                {
                     specialtyid = int.Parse(specialtyIDTextBox.Text);
                    SqlCommand search = new SqlCommand("SELECT COUNT(*) FROM Specialties Where Specialty_ID = @Specialty_ID", mycon);
                    search.Parameters.AddWithValue("@Specialty_ID", int.Parse(specialtyIDTextBox.Text));
                    int searchspecialty = (int)search.ExecuteScalar();

                    if (searchspecialty == 0)
                    {
                        MessageBox.Show("Specialty ID not found");
                        return;

                    }
                }
                string phonenumber;
                if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
                {
                    phonenumber = (string)doctorsDataGridView.SelectedRows[0].Cells[4].Value;
                }
                else
                {
                    phonenumber = phoneNumberTextBox.Text;
                    SqlCommand searchPhoneNumber = new SqlCommand("SELECT COUNT(*) FROM Doctors Where PhoneNumber = @PhoneNumber", mycon);
                    searchPhoneNumber.Parameters.AddWithValue("@PhoneNumber", int.Parse(phoneNumberTextBox.Text));
                    int countPhoneNumber = (int)searchPhoneNumber.ExecuteScalar();
                    if (countPhoneNumber > 0)
                    {
                        MessageBox.Show("This phone number already exist");
                        return;
                    }
                }
                //actualizare baze de date 
                SqlCommand cmd = new SqlCommand("UPDATE Doctors SET FirstName = @FirstName, LastName = @LastName, Specialty_ID = @Specialty_ID, PhoneNumber = @PhoneNumber  WHERE Doctor_ID = @Doctor_ID", mycon);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Specialty_ID", specialtyid);
                cmd.Parameters.AddWithValue("@PhoneNumber", phonenumber);
                cmd.Parameters.AddWithValue("@Doctor_ID", selectedDoctorId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                RefreshDataGrid();
                MessageBox.Show("Successfully updated");
                firstNameTextBox.Text = null;
                lastNameTextBox.Text = null;
                phoneNumberTextBox.Text = null;
                specialtyIDTextBox.Text = null;
            }
            else
            {
                MessageBox.Show("Please select a row to update");

            }
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

        private void specialtyIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    // daca nu este o cifra setam proprietatea handled => caracterul introdus e ingnorat
                    e.Handled = true;
                }
            }
        }
    }
}

