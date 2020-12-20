using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cars
{
    public partial class MalfunctionCertificate : Form
    {
        static SqlConnection _connection;

        public MalfunctionCertificate()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var r = new Regex(@"^\w?(\d{3})(\w{2}(\d{2,3})?)?");
            Console.WriteLine(r.IsMatch("123"));
            //Your code goes here
            Console.WriteLine("Hello, world!");

            if (!string.IsNullOrWhiteSpace(nameField.Text) && !string.IsNullOrWhiteSpace(surnameField.Text)
                && malfunctionCB.SelectedIndex > -1 && employeesCB.SelectedIndex > -1
                && !string.IsNullOrWhiteSpace(addressField.Text) && !string.IsNullOrWhiteSpace(carField.Text) 
                && r.IsMatch(numberField.Text) && int.TryParse(yearField.Text, out int s))
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }


        private void MalfunctionCertificate_Load(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = ("SELECT * FROM malfunctions");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.malfunctionCB.Items.Add(dataReader.GetValue(0));
            }

            query = ("SELECT * FROM employees");
            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.employeesCB.Items.Add(dataReader.GetValue(1).ToString() + " " +
                    dataReader.GetValue(2).ToString() + " " + dataReader.GetValue(3).ToString());
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            ownerLabel.Text = surnameField.Text + " " + nameField.Text + " " + parentalField.Text;
            malfunctionLabel.Text = malfunctionCB.SelectedItem.ToString();
            employeeLabel.Text = employeesCB.SelectedItem.ToString();

            modelLabel.Text = carField.Text;
            numberLabel.Text = numberField.Text;
            yearLabel.Text = yearField.Text;

            panel1.Visible = true;
        }
    }
}
