using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectII
{
    public partial class employeesform : Form
    {
        SqlConnection mycon = new SqlConnection();
        public employeesform()
        {
            InitializeComponent();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\skolika\\anu3\\semestru2\\ii_laborator\\proiectII\\proiectII\\Database.mdf;Integrated Security=True";
           

        }

        public void RefreshDataGrid()
        {
            mycon.Open();
            SqlCommand reset = new SqlCommand("SELECT * FROM Employees", mycon);
            SqlDataAdapter mydataAdapter = new SqlDataAdapter();
            mydataAdapter.SelectCommand = reset;
            DataTable table = new DataTable();
            mydataAdapter.Fill(table);//umplem datatable cu comandat sql data
                                      //setam sursa de date de la datagrid cu cel de la datatable
            employeesDataGridView.DataSource = table;
            mycon.Close();
        }

        private void employeesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter1.Fill(this.databaseDataSet.Employees);
            // TODO: This line of code loads data into the 'databaseDataSet1.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.databaseDataSet1.Employees);

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

        private void insertBtn_Click(object sender, EventArgs e)
        {
            mycon.Open();
            SqlCommand searchpassword = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Password = @Password", mycon);
           searchpassword.Parameters.AddWithValue("@Password", passwordTextBox.Text);  
            int countpassword = (int)searchpassword.ExecuteScalar();
            
            bool access = true;
            if(string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                access = false;
                MessageBox.Show("First Name field is required");
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                access = false;
                MessageBox.Show("Last Name  field is required");

            }
            if(string.IsNullOrEmpty(passwordTextBox.Text))
            {
                access = false;
                MessageBox.Show("Password field is required");
            } 
            if (countpassword > 0)
            {
                access = false;
                MessageBox.Show("This password already exist");
            }
            if (access)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Employees values ( @FirstName, @LastName, @Password, @PermissionLevel)", mycon);
                cmd.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully inserted");
                mycon.Close();
                RefreshDataGrid();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                int selectedEmployeesId = (int)employeesDataGridView.SelectedRows[0].Cells[0].Value; //sterge
                employeesDataGridView.Rows.RemoveAt(employeesDataGridView.SelectedRows[0].Index);
                //comanda sql de stergere din baza de date 
                SqlCommand cmd = new SqlCommand("Delete FROM Employees WHERE Employee_ID = @Employee_ID", mycon);
                cmd.Parameters.AddWithValue("@Employee_Id", selectedEmployeesId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (employeesDataGridView.SelectedRows.Count > 0)
            {

                mycon.Open();
                SqlCommand searchpassword = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Password = @Password", mycon);
                searchpassword.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                int countpassword = (int)searchpassword.ExecuteScalar();
                //se preiau valorile din textbox

                // preluare id angajat din randul selectat de noi
                int selectedEmployeeId = (int)employeesDataGridView.SelectedRows[0].Cells[0].Value;
                //verificare daca firstname textbox gol
                string firstname;
                if (string.IsNullOrEmpty(firstNameTextBox.Text))
                {
                    firstname = (string)employeesDataGridView.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    firstname = firstNameTextBox.Text;
                }
                string lastname;
                if (string.IsNullOrEmpty(lastNameTextBox.Text))
                {
                    lastname = (string)employeesDataGridView.SelectedRows[0].Cells[2].Value;
                }
                else
                {
                    lastname = lastNameTextBox.Text;
                }
                string password;
                if(string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    password = (string)employeesDataGridView.SelectedRows[0].Cells[3].Value;
                }
                else
                {
                    password=passwordTextBox.Text;
                    if(countpassword > 0)
                    {
                        MessageBox.Show("This password already exist");
                        return;
                    }

                }
                


                //actualizare baze de date 
                SqlCommand cmd = new SqlCommand("UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Password = @Password  WHERE Employee_ID = @Employee_ID", mycon);
                cmd.Parameters.AddWithValue("@FirstName", firstname);
                cmd.Parameters.AddWithValue("@LastName", lastname);
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@Employee_ID", selectedEmployeeId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                RefreshDataGrid();
                MessageBox.Show("Successfully updated");
            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }
        }

       
    }
    }

