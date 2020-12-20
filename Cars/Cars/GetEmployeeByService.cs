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
    public partial class GetEmployeeByService : Form
    {
        static SqlConnection _connection;

        public GetEmployeeByService()
        {
            InitializeComponent();
        }

        private void GetEmployeeByService_Load(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = ("SELECT * FROM malfunctions");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.malfucntions.Items.Add(dataReader.GetValue(0));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var r = new Regex(@"^\w?(\d{3})(\w{2}(\d{2,3})?)?");
            if (r.IsMatch(this.textBox1.Text) && malfucntions.SelectedIndex >= 0)
            {
                this.button1.Enabled = true;
            }
            else
            {
                this.button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = string.Format("SELECT id FROM cars WHERE reg_number = '{0}'", this.textBox1.Text);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            string carId = null;

            while (dataReader.Read())
            {
                carId = dataReader.GetValue(0).ToString();
            }

            if(carId != null)
            {
                query = string.Format("SELECT * FROM services WHERE car_id = '{0}' AND malfunction_id = '{1}'", carId, this.malfucntions.SelectedItem.ToString());
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();

                string res = "";
                string employeeId = null;

                while (dataReader.Read())
                {
                    res += "Часы: " + dataReader.GetValue(3) + " Сотрудник: ";
                    employeeId = dataReader.GetValue(4).ToString();
                }

                query = string.Format("SELECT * FROM employees WHERE id = '{0}' ", employeeId);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    res += dataReader.GetValue(1).ToString() + " ";
                    res += dataReader.GetValue(2).ToString() + " ";
                    res += dataReader.GetValue(3).ToString() + " ";
                }

                this.result.Text = res;
            }
            else
            {
                this.result.Text = "Ничего не найдено";
            }
        }
    }
}
