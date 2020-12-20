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
    public partial class GetServicesByOwner : Form
    {
        static SqlConnection _connection;

        public GetServicesByOwner()
        {
            InitializeComponent();
        }

        private void surnameField_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.surnameField.Text) && !string.IsNullOrEmpty(this.nameField.Text))
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

            String query = string.Format("SELECT id FROM owners WHERE name = '{0}' AND surname = '{1}' AND parental = '{2}'", this.nameField.Text, this.surnameField.Text, this.parentalField.Text);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string ownerId = null;
            while (dataReader.Read())
            {
                ownerId = dataReader.GetValue(0).ToString();
            }

            if (ownerId != null)
            {
                query = string.Format("SELECT id FROM cars WHERE owner_id = '{0}'", ownerId);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();
                string car_id = "";
                while (dataReader.Read())
                {
                    car_id = dataReader.GetValue(0).ToString();
                }

                query = string.Format("SELECT * FROM services WHERE car_id = '{0}'", car_id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();
                string res = "";
                while (dataReader.Read())
                {
                    res += dataReader.GetValue(2).ToString() + " ";
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
