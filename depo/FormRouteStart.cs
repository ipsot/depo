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
    public partial class FormRouteStart : Form
    {
        public FormRouteStart()
        {
            InitializeComponent();
        }

        MySqlCommand command;
        MySqlConnection connection;

        List<RouteStart> starts;


        private void LoadDataGrid()
        {
            try
            {
                string connectinString = "Server=127.0.0.1;Port=3306;Database=depo;User=root;Password=1234";
                connection = new MySqlConnection(connectinString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;

                command.CommandText = $"Select * from `route_start`";
                MySqlDataReader servicesReader = command.ExecuteReader();
                starts = new List<RouteStart>();


                dataGridView1.Rows.Clear();
                while (servicesReader.Read())
                {
                    int id = servicesReader.GetInt32("Id");
                    string name = servicesReader.GetString("Name");


                    dataGridView1.Rows.Add(id, name);
                }
                servicesReader.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при загрузне БД");
                return;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRoute().Show();
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
                command.CommandText = $"delete from `route_start` where `id`={selectedId}";
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;



                command.CommandText = $"insert into `route_start` (`Id`,`Name`) values (0,'{textBox1.Text}')";
                command.ExecuteNonQuery();
                MessageBox.Show("Путь добавлен");
                LoadDataGrid();

            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении нового пути");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormRouteStart_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }
    }
}
