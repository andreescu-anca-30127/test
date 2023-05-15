using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectII
{
    public partial class specialtiesform : Form
    {
       SqlConnection mycon = new SqlConnection();
        public specialtiesform()
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
            SqlCommand reset = new SqlCommand("SELECT * FROM Specialties", mycon);
            // s-a creat o instanta DataAdapter ca sa putem citii datele din baza de date 
            SqlDataAdapter mydataAdapter = new SqlDataAdapter();
            mydataAdapter.SelectCommand = reset;
            DataTable table = new DataTable();
            mydataAdapter.Fill(table);//umplem datatable cu comandat sql data
                                      //setam sursa de date de la datagrid cu cel de la datatable
            specialtiesDataGridView.DataSource = table;
            mycon.Close();
        }

        private void specialtiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specialtiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet1);

        }

        private void specialtiesform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.Specialties' table. You can move, or remove it, as needed.
            this.specialtiesTableAdapter.Fill(this.databaseDataSet1.Specialties);

        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                // permite introducerea numai literelor
                e.Handled = true;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (specialtiesDataGridView.SelectedRows.Count > 0)
            {
                
                mycon.Open();
                int selectedSpecialtiesID = (int)specialtiesDataGridView.SelectedRows[0].Cells[0].Value; //sterge
                specialtiesDataGridView.Rows.RemoveAt(specialtiesDataGridView.SelectedRows[0].Index);
                //comanda sql de stergere din baza de date
                SqlCommand cmd = new SqlCommand("DELETE FROM Specialties Where Specialty_ID = @Specialty_ID", mycon);
                cmd.Parameters.AddWithValue("@Specialty_ID", selectedSpecialtiesID);
                cmd.ExecuteNonQuery();
                mycon.Close();
                MessageBox.Show("Successfully deleted");
            }
            else
            {
                MessageBox.Show("Please select a row to delete");

            }
        }

        private void insertDoctorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool access = true;
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    access = false;
                    MessageBox.Show("Name field is required");
                }
                if (string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    access = false;
                    MessageBox.Show("Description field is required");
                }
                if (access)
                {
                    mycon.Open();
                    // verificam daca exista o specialitate cu acelasi nume
                    SqlCommand search = new SqlCommand("SELECT COUNT (*) FROM Specialties Where Name = @Name", mycon);
                    search.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    int nameCount = (int)search.ExecuteScalar();
                    if (nameCount > 0)
                    {
                        MessageBox.Show("This name already exist");
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Specialties values ( @Name, @Description)", mycon);
                        cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully inserted");
                        mycon.Close();
                        RefreshDataGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (specialtiesDataGridView.SelectedRows.Count > 0)
            {
                mycon.Open();
                //preluare id specialitate din randul selectat de noi
                int selectedSpecialityId = (int)specialtiesDataGridView.SelectedRows[0].Cells[0].Value;
                //verificare daca textboxul name e gol
                string name;
                if (string.IsNullOrEmpty(nameTextBox.Text))
                {
                    name = (string)specialtiesDataGridView.SelectedRows[0].Cells[1].Value;
                }
                else
                {
                    name = nameTextBox.Text;
                    SqlCommand check = new SqlCommand("SELECT COUNT (*) FROM Specialties Where Name = @Name", mycon);
                    check.Parameters.AddWithValue("@Name", name);
                    int checkName = (int)check.ExecuteScalar();
                    if (checkName > 0)
                    {
                        MessageBox.Show("This name already exist. Please enter a new name");
                        return;
                    }
                }
                string description;
                if(string.IsNullOrEmpty(descriptionTextBox.Text))
                {
                    description = (string)specialtiesDataGridView.SelectedRows[0].Cells[2].Value;

                }
                else
                {
                    description = descriptionTextBox.Text;
                   
                }
               
                // actualizare baza de date 
                SqlCommand cmd = new SqlCommand("UPDATE Specialties Set Name = @Name, Description = @Description WHERE Specialty_ID = @Specialty_ID", mycon);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Description", description);
                cmd.Parameters.AddWithValue("@Specialty_ID", selectedSpecialityId);
                cmd.ExecuteNonQuery();
                mycon.Close();
                RefreshDataGrid();
                MessageBox.Show("Successfully updated");
                nameTextBox.Text = null;
                descriptionTextBox.Text = null; 
                

            }
            else
            {
                MessageBox.Show("Please select a row to update");
            }


        }
    }
}
