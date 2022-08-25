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
    public partial class FormDriver : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        public FormDriver()
        {
            InitializeComponent();
        }

        private void FillDataGridViewDriver()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `driver`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridView1.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                int id_bus = mySqlDataReader.GetInt32("id_bus");
                string data = mySqlDataReader.GetString("data");
                int id_route = mySqlDataReader.GetInt32("id_route");

                dataGridView1.Rows.Add(id, id_bus, data,id_route);
            }
            mySqlDataReader.Close();
        }

        private void FormDriver_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewDriver();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке данных");
                return;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddNewDriver().Show();
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

                mySqlCommand.CommandText = $"Delete from `driver` where `id`={idDriver}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewDriver();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка при удалении");
                return;
            }
        }

        private void buttonMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMainMenu().Show();
        }

        private void buttonDriverAndBus_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDriverAndBus().Show();
        }
    }
}
