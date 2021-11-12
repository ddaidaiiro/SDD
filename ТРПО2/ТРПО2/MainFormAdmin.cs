using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТРПО2
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainFormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            AddRecord addrec = new AddRecord();
            addrec.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void РегистрацияПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationPatient registrationPat = new RegistrationPatient();
            registrationPat.ShowDialog();
        }

        private void ЛичныйКабинетПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientPersonalAccount persacc = new PatientPersonalAccount();
            persacc.ShowDialog();
        }

        
        private void MainFormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }   
}


