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
    public partial class RemoveEmployee : Form
    {
        static SqlConnection _connection;

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

        public RemoveEmployee()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(employeesCB.SelectedIndex >= 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Удалить сотрудника?", "Подтвердите выбор", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                String query = String.Format("DELETE FROM employees WHERE id = {0}", (this.employeesCB.SelectedItem as Employee).id);

                SqlCommand command = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Удаление прошло успешно!");
                this.employeesCB.Items.Clear();
                this.employeesCB.ResetText();
                this.employeesCB.SelectedIndex = -1;
                this.RemoveEmployee_Load(sender, e);
            }

        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
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
    }
}
