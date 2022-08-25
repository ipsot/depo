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
    public partial class FormDriverAndBus : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;

        List<Driver> drivers;
        List<Bus> buses;
        public FormDriverAndBus()
        {
            InitializeComponent();
        }

        private void FillDataGridViewDriverAndBus()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "SELECT *from driver_and_bus as dab JOIN driver as d on dab.id_driver=d.id";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridView1.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string driver = mySqlDataReader.GetString(5);
                int id_bus = mySqlDataReader.GetInt32("id_bus");

                dataGridView1.Rows.Add(id, driver, id_bus);
            }
            mySqlDataReader.Close();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите элемент для удаления");
                    return;
                }
                int idDriver = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `driver_and_bus` where `id`={idDriver}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewDriverAndBus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddDriverAndBus().Show();
            
        }

        private void buttonGoToDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDriver().Show();
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }

        private void FormDriverAndBus_Load(object sender, EventArgs e)
        {

            FillDataGridViewDriverAndBus();

        }
    }
}
