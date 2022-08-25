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
    public partial class FormAddDriverAndBus : Form
    {
        public FormAddDriverAndBus()
        {
            InitializeComponent();
        }

        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;

        List<Driver> drivers;
        List<Bus> buses;
        List<DriverAndBus> driverAndBuses;

        //private void LoadDriverAndBus()
        //{
        //    mySqlCommand.CommandText = "select* from `driver_and_bus`";
        //    MySqlDataReader reader = mySqlCommand.ExecuteReader();

        //    while (reader.Read())
        //    {
        //        int id = reader.GetInt32("id");
        //        int id_driver = reader.GetInt32("id_driver");
        //        int id_bus = reader.GetInt32("id_bus");

        //        driverAndBuses.Add(new DriverAndBus()
        //        {
        //            Id = id,
        //            Id_Driver=id_driver,
        //            Id_Bus=id_bus
        //        });

        //    }
        //    reader.Close();
        //}

        private void LoadDriverForDriverAndBus()
        {
            mySqlCommand.CommandText = "select* from `driver`";
            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int id_bus = reader.GetInt32("id_bus");
                string data = reader.GetString("data");
                int id_route = reader.GetInt32("id_route");

                drivers.Add(new Driver()
                {
                    Id = id,
                    Id_Bus = id_bus,
                    Data = data,
                    Id_Route = id_route
                });

            }
            reader.Close();
        }

        private void LoadBusForDriverAndBus()
        {
            mySqlCommand.CommandText = "select* from `bus`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string type = reader.GetString("type");
                string model = reader.GetString("model");
                DateTime dateTime = reader.GetDateTime("date_ts");
                int sitting_count = reader.GetInt32("sitting_count");
                int id_ts = reader.GetInt32("id_ts");

                buses.Add(new Bus()
                {
                    Id = id,
                    Type = type,
                    Model = model,
                    dateTimeTS = dateTime,
                    SittingCount = sitting_count,
                    id_ts = id_ts

                });

            }
            reader.Close();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = connection;

                List<Driver> drivers;
                List<Bus> buses;

                int idDriver = ((Driver)comboBox1.SelectedItem).Id;
                int idBus = ((Bus)comboBox2.SelectedItem).Id;


                mySqlCommand.CommandText = $"insert into `driver_and_bus` (`id`,`id_driver`,`id_bus`) values (0,'{idDriver}','{idBus}')";
                mySqlCommand.ExecuteNonQuery();

                this.Hide();
                new FormDriverAndBus().Show();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDriverAndBus().Show();
        }

        private void FormAddDriverAndBus_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            drivers = new List<Driver>();
            buses = new List<Bus>();

            try
            {
                LoadDriverForDriverAndBus();
                comboBox1.DataSource = drivers;
                comboBox1.DisplayMember = "Data";
            }
            catch (Exception)
            {
                throw;
            }

            try
            {
                LoadBusForDriverAndBus();
                comboBox2.DataSource = buses;
                comboBox2.DisplayMember = "Id";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
