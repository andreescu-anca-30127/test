using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace proiectII
{
    public partial class Form1 : Form
    {
        SqlConnection mycon = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            mycon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\skolika\\anu3\\semestru2\\ii_laborator\\proiectII\\proiectII\\Database.mdf;Integrated Security=True";
            mycon.Open();
            mycon.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string FirstName = usernameTextBox.Text;
            string Password = passwordTextBox.Text;

            mycon.Open();
            //verifica daca valorile sunt nule 
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(Password))
            {
                MessageBox.Show("Username and Password are required");
                return;
            }
            SqlCommand cmd = new SqlCommand("SELECT PermissionLevel FROM Employees WHERE FirstName = @Username AND Password = @Password", mycon);
            cmd.Parameters.AddWithValue("username", FirstName);
            cmd.Parameters.AddWithValue("password", Password);

            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                int PermissionLevel;
                if(int.TryParse(result.ToString(), out PermissionLevel))

                this.Visible = false; // Ascunde Formularul 1

                MeniuForm menuForm = new MeniuForm(PermissionLevel);
                menuForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            
        }

           mycon.Close();
    
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != ' ' &&  e.KeyChar != (char)Keys.Back)
            {
                // permite introducerea numai literelor
                e.Handled = true;
            }
        }
        
       

        private void showPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {

            if (showPasswordCheckbox.Checked)
            {

                passwordTextBox.UseSystemPasswordChar = false; //afiseaza parola
            }
            else
            {

                passwordTextBox.UseSystemPasswordChar = true; //ascunde parola
            }
        }
    }
}



