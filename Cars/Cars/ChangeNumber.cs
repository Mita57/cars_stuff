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
    public partial class ChangeNumber : Form
    {
        public ChangeNumber()
        {
            InitializeComponent();
        }

        static SqlConnection _connection;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var r = new Regex(@"^\w?(\d{3})(\w{2}(\d{2,3})?)?");

            if (r.IsMatch(this.oldNumber.Text) && r.IsMatch(this.newNumber.Text))
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

            String query = string.Format("SELECT id FROM cars WHERE reg_number = '{0}'", this.oldNumber.Text);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            bool numberExists = false;

            while (dataReader.Read())
            {
                numberExists = true;

                string carId = dataReader.GetValue(0).ToString();

                query = String.Format("UPDATE cars SET reg_number = '{0}' WHERE id = '{1}'", this.newNumber.Text, carId );

                command = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
            }

            if(!numberExists)
            {
                MessageBox.Show("Такого номера нет в системе!");
            }
            else
            {
                MessageBox.Show("Операция прошла успешно!");
                this.newNumber.Clear();
                this.oldNumber.Clear();
            }
        }
    }
}
