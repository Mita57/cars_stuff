using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetOwnerByNumber sas = new GetOwnerByNumber();
            sas.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetCarByOwner sas = new GetCarByOwner();
            sas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetServicesByOwner sas = new GetServicesByOwner();
            sas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetEmployeeByService sas = new GetEmployeeByService();
            sas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetServicesByEmployee sas = new GetServicesByEmployee();
            sas.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OwnersByMalfunctions sas = new OwnersByMalfunctions();
            sas.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddOwnerInfo sas = new AddOwnerInfo();
            sas.Show();
        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            RemoveEmployee sas = new RemoveEmployee();
            sas.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeNumber sas = new ChangeNumber();
            sas.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MalfunctionCertificate sas = new MalfunctionCertificate();
            sas.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Report sas = new Report();
            sas.Show();
        }
    }
}
