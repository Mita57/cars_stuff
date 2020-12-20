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
    public partial class OwnersByMalfunctions : Form
    {
        static SqlConnection _connection;

        public OwnersByMalfunctions()
        {
            InitializeComponent();
        }

        private void OwnersByMalfunctions_Load(object sender, EventArgs e)
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

        private void malfucntions_SelectedIndexChanged(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = string.Format("SELECT car_id FROM services WHERE malfunction_id = '{0}'", this.malfucntions.SelectedItem);
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            List<string> carIds = new List<string>();

            while (dataReader.Read())
            {
                carIds.Add(dataReader.GetValue(0).ToString());
            }

            List<string> ownerIds = new List<string>();

            foreach (string id in carIds)
            {
                query = string.Format("SELECT owner_id FROM cars WHERE id = '{0}'", id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();               

                while(dataReader.Read())
                {
                    ownerIds.Add(dataReader.GetValue(0).ToString());
                }

            }

            string res = "";

            foreach(string id in ownerIds)
            {
                query = string.Format("SELECT * FROM owners WHERE id = '{0}'", id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    res += dataReader.GetValue(1).ToString() + " " +
                        dataReader.GetValue(2).ToString() + " " +
                        dataReader.GetValue(3).ToString() + "\n";
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
