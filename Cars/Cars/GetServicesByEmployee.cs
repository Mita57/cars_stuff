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

namespace Cars
{
    public partial class GetServicesByEmployee : Form
    {
        class Employee
        {
            string name;
            string surname;
            string parental;
            public string id;

            public Employee(string name, string surname, string parental, string id)
            {
                this.name = name;
                this.surname = surname;
                this.parental = parental;
                this.id = id;
            }

            public override string ToString()
            {
                return this.surname + " " + this.name + " " + this.parental;
            }
        }

        static SqlConnection _connection;

        public GetServicesByEmployee()
        {
            InitializeComponent();
        }

        private void GetServicesByEmployee_Load(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = ("SELECT * FROM employees");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                this.employeesCB.Items.Add(new Employee(dataReader.GetValue(1).ToString(),
                    dataReader.GetValue(2).ToString(),
                    dataReader.GetValue(3).ToString(),
                    dataReader.GetValue(0).ToString()
                    ));
            }
        }

        private void employeesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string employeeId = (employeesCB.SelectedItem as Employee).id;

            String query = string.Format("SELECT car_id FROM services WHERE employee_id = '{0}'", employeeId);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            List<string> car_ids = new List<string>();

            while (dataReader.Read())
            {
                car_ids.Add(dataReader.GetValue(0).ToString());
            }

            string res = "";

            foreach(string id in car_ids)
            {
                query = string.Format("SELECT model FROM cars WHERE id = '{0}'", id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    res += dataReader.GetValue(0).ToString() + "\n";
                }

            }

            if(res == "")
            {
                this.result.Text = "Ничего не найдено";
            }
            else
            {
                this.result.Text = res;
            }

        }
    }
}
