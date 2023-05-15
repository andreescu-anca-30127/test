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

namespace proiectII
{
    public partial class MeniuForm : Form
    {
        SqlConnection myCon = new SqlConnection();
        private int PermissionLevel;
        public MeniuForm(int PermissionLvel)
        {
            InitializeComponent();
            this.PermissionLevel = PermissionLvel;
            if(PermissionLvel == 2)//ADMIN
            {
                employeesBtn.Enabled = false;
            }
            else 
            {
                appointmentsBtn.Enabled = false;
                patientsBtn.Enabled = false;
                specialtiesBtn.Enabled = false;
                doctorsBtn.Enabled = false;
            }
            
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\skolika\anu3\semestru2\ii_laborator\proiectII\proiectII\Database.mdf;Integrated Security=True";
            myCon.Open();

            myCon.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false; // Ascunde Formul 2
            Form1 form1 = new Form1();
            form1.Visible = true; // Arată Formul 1
        }

        

        private void appointmentsBtn_Click(object sender, EventArgs e)
        {
            //cream o instanta a fomrularului appoitmentform
            appointmentsform appointmentsForm = new appointmentsform();
            //formularul sa fie tratat ca un control si sa poata sa fie afisat in mainpanel
            appointmentsForm.TopLevel = false;
            //formularul sa ocupe intreaga suprafata a panoului "mainPanel"
            appointmentsForm.Dock = DockStyle.Fill;
            //stergem orice control din panoul principal
            mainPanel.Controls.Clear();
            //adaugam in panoul principal formul dorit
            mainPanel.Controls.Add(appointmentsForm);
            //afisarea formului
            appointmentsForm.Show();
        }

        private void employeesBtn_Click(object sender, EventArgs e)
        {

            employeesform employeesForm = new employeesform();
            employeesForm.TopLevel = false;
            employeesForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(employeesForm);
            employeesForm.Show();

       
        }

        private void doctorsBtn_Click(object sender, EventArgs e)
        {
            doctorsform doctorsForm = new doctorsform();
            doctorsForm.TopLevel = false;
            doctorsForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(doctorsForm);
            doctorsForm.Show();
        }

        private void patientsBtn_Click(object sender, EventArgs e)
        {
            patientsform patientsForm = new patientsform();
            patientsForm.TopLevel = false;
            patientsForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(patientsForm);
            patientsForm.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void specialtiesBtn_Click(object sender, EventArgs e)
        {
            specialtiesform specialtiesform = new specialtiesform();
            specialtiesform.TopLevel = false;
            specialtiesform.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(specialtiesform);
            specialtiesform.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            timeLabel.Text = datetime.ToString("HH:mm:ss");
        }

        private void MeniuForm_Load(object sender, EventArgs e)
        {
            //setare interval timer la o secunda 
            timer1.Interval = 1000;
            //pornire timer 
            timer1.Start();
        }
    }
}
