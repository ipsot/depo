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
    public partial class FormRoute : Form
    {
        public FormRoute()
        {
            InitializeComponent();
        }

        MySqlCommand command;
        MySqlConnection connection;


        List<Route> routes;
        List<RouteStart> starts;
        List<RouteFinish> finishes;


        private void LoadDataGrid()
        {
            try
            {
                string connectinString = "Server=127.0.0.1;Port=3306;Database=depo;User=root;Password=1234";
                connection = new MySqlConnection(connectinString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = $"Select * from `route` as ro JOIN route_start as rs on rs.id=ro.id_start JOIN route_finish as rf on rf.id=ro.id_finish";
                MySqlDataReader servicesReader = command.ExecuteReader();
                routes = new List<Route>();


                dataGridView1.Rows.Clear();
                while (servicesReader.Read())
                {
                    int id = servicesReader.GetInt32("Id");
                    string idRouteStart = servicesReader.GetString(4);
                    string idRouteFinish = servicesReader.GetString(6);


                    dataGridView1.Rows.Add(id, idRouteStart, idRouteFinish);
                }
                servicesReader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при загрузне БД");
                return;
            }

        }

        private void LoadStart()
        {
            command.CommandText = "select * from `route_start`";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                starts.Add(new RouteStart()
                {
                    Id = id,
                    Name = name
                });
            }
            reader.Close();
        }

        private void LoadFinish()
        {
            command.CommandText = "select * from `route_finish`";
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string name = reader.GetString("name");

                finishes.Add(new RouteFinish()
                {
                    Id = id,
                    Name = name
                });
            }
            reader.Close();
        }
        private void FormRoute_Load(object sender, EventArgs e)
        {
            LoadDataGrid();

            routes = new List<Route>();
            starts = new List<RouteStart>();
            finishes = new List<RouteFinish>();



            try
            {
                LoadStart();
                comboBoxStart.DataSource = starts;
                comboBoxStart.DisplayMember = "Name";
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке начальных путей");
                return;
            }

            try
            {
                LoadFinish();

                comboBoxFinish.DataSource = finishes;
                comboBoxFinish.DisplayMember = "name";

            }
            catch
            {
                MessageBox.Show("Ошибка загрузке конечных путей");
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
                command.CommandText = $"delete from `route` where `id`={selectedId}";
                command.ExecuteNonQuery();
                LoadDataGrid();
                MessageBox.Show("Путь удален");


            }
            catch
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
        }

        private void buttonAddStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRouteStart().Show();
        }

        private void buttonAddFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRouteFinish().Show();
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

                int id1 = ((RouteStart)(comboBoxStart.SelectedItem)).Id;
                int id2 = ((RouteFinish)(comboBoxFinish.SelectedItem)).Id;



                command.CommandText = $"insert into `route` (`Id`,`id_start`,`id_finish`) values (0,'{id1}','{id2}')";
                command.ExecuteNonQuery();
                MessageBox.Show("Путь добавлен");
                LoadDataGrid();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении нового пути");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }
    }
}
