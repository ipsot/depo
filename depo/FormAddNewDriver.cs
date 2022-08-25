using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depo
{
    public partial class FormAddNewDriver : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        public FormAddNewDriver()
        {
            InitializeComponent();
        }

        List<Route> routes;
        List<Bus> buses;

        private void LoadRoute()
        {
            mySqlCommand.CommandText = "select* from `route`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int id_start = reader.GetInt32("id_start");
                int id_finish = reader.GetInt32("id_finish");

                routes.Add(new Route()
                {
                    Id = id,
                   Id_Start=id_start,
                   Id_Finish=id_finish
                });

            }
            reader.Close();
        }

        private void LoadBus()
        {
            mySqlCommand.CommandText = "select* from `bus`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string type = reader.GetString("type");
                string model = reader.GetString("model");
                DateTime date = reader.GetDateTime("date_ts");
                int sittingCount = reader.GetInt32("sitting_count");
                int id_ts = reader.GetInt32("id_ts");

                buses.Add(new Bus()
                {
                    Id = id,
                    Type=type,
                    Model=model,
                    dateTimeTS=date,
                    SittingCount=sittingCount,
                    id_ts=id_ts
                });

            }
            reader.Close();
        }

        private void FormAddNewDriver_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;

            buses = new List<Bus>();
            routes = new List<Route>();
            try
            {
                LoadBus();
                comboBoxNumberBus.DataSource = buses;
                comboBoxNumberBus.DisplayMember = "id";
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                LoadRoute();
                comboBox1.DataSource = routes;
                comboBox1.DisplayMember = "id";
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;

                List<Bus> buses;
                List<Route> routes;

                int idBus = ((Bus)comboBoxNumberBus.SelectedItem).Id;
                int idRoute = ((Route)comboBox1.SelectedItem).Id;

                if (textBox1.Text == null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                mySqlCommand.CommandText = $"insert into `driver` (`id`,`id_bus`,`data`,`id_route`) values (0,'{idBus}','{textBox1.Text}','{idRoute}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormDriver().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDriver().Show();
        }
    }
}
