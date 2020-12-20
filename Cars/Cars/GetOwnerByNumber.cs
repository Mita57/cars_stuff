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
    public partial class GetOwnerByNumber : Form
    {
        static SqlConnection _connection;

        public GetOwnerByNumber()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var r = new Regex(@"^\w?(\d{3})(\w{2}(\d{2,3})?)?");
            if(r.IsMatch(this.numberField.Text))
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

            String query = string.Format("SELECT owner_id FROM cars WHERE reg_number = '{0}'", this.numberField.Text);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string ownerId = null;
            while (dataReader.Read())
            {
                ownerId = dataReader.GetValue(0).ToString();
            }

            if(ownerId != null)
            {
                query = string.Format("SELECT * FROM owners WHERE id = '{0}'", ownerId);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();
                string res = "";
                while (dataReader.Read())
                {
                    res += dataReader.GetValue(1).ToString() + " ";
                    res += dataReader.GetValue(2).ToString() + " ";
                    res += dataReader.GetValue(3).ToString() + " ";
                    res += dataReader.GetValue(4).ToString() + " ";
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
