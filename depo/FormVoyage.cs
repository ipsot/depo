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
    public partial class FormVoyage : Form
    {
        public FormVoyage()
        {
            InitializeComponent();
        }

        MySqlCommand command;
        MySqlConnection connection;


        List<Driver> drivers;
        List<Route> routes;
        List<Voyage> voyages;

        private void LoadDriver()
        {
            command.CommandText = "select * from `driver`";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int id_bus = reader.GetInt32("id_bus");
                string data = reader.GetString("data");
                int id_route = reader.GetInt32("id_route");

                drivers.Add(new Driver()
                {
                    Id = id,
                    Data = data,
                    Id_Bus = id_bus,
                    Id_Route = id_route

                });
            }
            reader.Close();
        }

        private void LoadRoute()
        {
            command.CommandText = "select * from `route`";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int id_start = reader.GetInt32("id_start");
                int id_finish = reader.GetInt32("id_finish");


                routes.Add(new Route()
                {
                    Id = id,
                    Id_Start = id_start,
                    Id_Finish = id_finish

                });
            }
            reader.Close();
        }

        private void LoadDataGrid()
        {
            try
            {
                string connectinString = "Server=127.0.0.1;Port=3306;Database=depo;User=root;Password=1234";
                connection = new MySqlConnection(connectinString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = $"Select * from `voyage` as v JOIN driver as d on v.id_driver=d.id JOIN route as r on v.id_route=d.id";
                MySqlDataReader servicesReader = command.ExecuteReader();
                voyages = new List<Voyage>();


                dataGridView1.Rows.Clear();
                while (servicesReader.Read())
                {
                    int id = servicesReader.GetInt32("Id");
                    string data = servicesReader.GetString(7);
                    int idRoute = servicesReader.GetInt32(8);
                    string start = servicesReader.GetString(3);
                    string finish = servicesReader.GetString(4);

                    dataGridView1.Rows.Add(id, data, idRoute, start, finish);
                }
                servicesReader.Close();



            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при загрузне БД");
                return;
            }


        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                int selectedId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                command.CommandText = $"delete from `voyage` where `id`={selectedId}";
                command.ExecuteNonQuery();
                LoadDataGrid();
                MessageBox.Show("Рейс удален");


            }
            catch
            {
                MessageBox.Show("Ошибка при удалении ");
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                int idDriver = ((Driver)(comboBoxDriver.SelectedItem)).Id;
                int idRoute = ((Route)(comboBoxRoute.SelectedItem)).Id;


                string time1 = (string)comboBoxStart.SelectedItem;
                string time2 = (string)comboBoxFinish.SelectedItem;



                command.CommandText = $"insert into `voyage` (`Id`,`id_driver`,`id_route`,`time_start`,`time_finish`) values (0,'{idDriver}','{idRoute}','{time1}','{time2}')";
                command.ExecuteNonQuery();
                MessageBox.Show("Рейс добавлен");
                LoadDataGrid();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void FormVoyage_Load(object sender, EventArgs e)
        {
            LoadDataGrid();

            drivers = new List<Driver>();
            routes = new List<Route>();
            voyages = new List<Voyage>();


            try
            {
                LoadDriver();
                comboBoxDriver.DataSource = drivers;
                comboBoxDriver.DisplayMember = "Data";
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке водителей");
                return;
            }

            try
            {
                LoadRoute();

                comboBoxRoute.DataSource = routes;
                comboBoxRoute.DisplayMember = "id";

            }
            catch
            {
                MessageBox.Show("Ошибка загрузке путей");
                return;
            }

            comboBoxStart.SelectedIndex = 0;
            comboBoxFinish.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
