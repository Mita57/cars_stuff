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
    public partial class AddOwnerInfo : Form
    {
        static SqlConnection _connection;

        public AddOwnerInfo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var r = new Regex(@"^\w?(\d{3})(\w{2}(\d{2,3})?)?");
            if (r.IsMatch(this.numberField.Text) && !string.IsNullOrWhiteSpace(this.nameField.Text)
                && !string.IsNullOrWhiteSpace(this.surnameField.Text) && !string.IsNullOrWhiteSpace(adressField.Text))
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

            string carId = null;

            String query = string.Format("SELECT COUNT(*), id FROM cars WHERE reg_number = '{0}' GROUP BY id", this.numberField.Text);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            string res = "0";

            while (dataReader.Read())
            {
                res = dataReader.GetValue(0).ToString();
                carId = dataReader.GetValue(1).ToString();
            }

            if (res == "0")
            {
                MessageBox.Show("Машина с такими номерами на зарегистрирована в системе!");
                return;
            }

            query = string.Format("SELECT id, COUNT(*) FROM owners WHERE name = '{0}' AND surname = '{1}' AND parental = '{2}' AND address = '{3}' GROUP BY id", this.nameField.Text, this.surnameField.Text, this.parentalField.Text, this.adressField.Text);

            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();

            res = "0";

            string id = null;

            bool userExists = false;

            while (dataReader.Read())
            {
                userExists = true;

                id = dataReader.GetValue(0).ToString();
                query = string.Format("UPDATE cars SET owner_id = '{0}' WHERE id = {1}", id, carId);

                command = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Операция прошла успешно");
                return;

            }

            if(!userExists)
            {
                query = string.Format("INSERT INTO owners(name, surname, parental, address) VALUES ('{0}', '{1}', '{2}', '{3}')", this.nameField.Text, this.surnameField.Text, this.parentalField.Text, this.adressField.Text);


                command = new SqlCommand(query, _connection);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command;
                adapter.UpdateCommand.ExecuteNonQuery();
                command.Dispose();
                button1_Click(sender, e);
                return;
            }

        }
    }
}
