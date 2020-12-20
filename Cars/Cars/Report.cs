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
    public partial class Report : Form
    {
        static SqlConnection _connection;

        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            String connectString = @"Data Source = LAPTOP-2HPKOMO8\SQLEXPRESS; Initial Catalog = Cars;User ID = sa; password = 1234; MultipleActiveResultSets=true";
            _connection = new SqlConnection(connectString);
            _connection.Open();

            String query = ("SELECT COUNT(DISTINCT car_id) FROM services GROUP BY car_id");
            SqlCommand command = new SqlCommand(query, _connection);
            SqlDataReader dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                label1.Text += dataReader.GetValue(0).ToString();
            }

            query = ("SELECT DISTINCT car_id FROM services GROUP BY car_id");
            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();
            List<string> carIds = new List<string>();

            while (dataReader.Read())
            {
                carIds.Add(dataReader.GetValue(0).ToString());
            }

            List<string> hours = new List<string>();

            List<string> carNames = new List<string>();

            foreach (string id in carIds)
            {
                query = string.Format("SELECT SUM(work_time_in_hrs) FROM services WHERE car_id = '{0}' GROUP BY car_id", id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    hours.Add(dataReader.GetValue(0).ToString());
                }

                query = string.Format("SELECT model, reg_number FROM cars WHERE id = '{0}'", id);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    carNames.Add(dataReader.GetValue(0).ToString() + " " + dataReader.GetValue(1).ToString());
                }

            }

            string res = "";

            for (int i = 0; i < carNames.Count; i++)
            {
                res += carNames[i] + ": " + hours[i];
            }

            richTextBox1.Text = res;


            List<string> allCarNames = new List<string>();
            List<string> allCarIds = new List<string>();

            query = string.Format("SELECT id, model, reg_number FROM cars");
            command = new SqlCommand(query, _connection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                allCarNames.Add(dataReader.GetValue(1).ToString() + " " +  dataReader.GetValue(2).ToString());
                allCarIds.Add(dataReader.GetValue(0).ToString());
            }

            List<string> malsByCar = new List<string>();

            foreach(string carId in allCarIds)
            {
                query = string.Format("SELECT DISTINCT(malfunction_id) FROM services WHERE car_id = '{0}'", carId);
                command = new SqlCommand(query, _connection);
                dataReader = command.ExecuteReader();

                string mals = "";

                while (dataReader.Read())
                {
                    mals += dataReader.GetValue(0).ToString();
                }

                malsByCar.Add(mals);
            }

            string malsRes = "";

            for(int i = 0; i < allCarIds.Count; i++)
            {
                malsRes += allCarNames[i] + ": " + malsByCar[i] + "\n";
            }

            richTextBox2.Text = malsRes;
        }
    }
}
