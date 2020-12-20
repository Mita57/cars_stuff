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
    }
}
