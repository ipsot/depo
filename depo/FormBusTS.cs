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
    public partial class FormBusTS : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;
        public FormBusTS()
        {
            InitializeComponent();
        }

        private void FillDataGridViewBusTS()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `ts_bus`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewBusTS.Rows.Clear();


            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                int mileage = mySqlDataReader.GetInt32("mileage");
                string changeDetails = mySqlDataReader.GetString("change_details");
                string change_consumables = mySqlDataReader.GetString("change_consumables");

                dataGridViewBusTS.Rows.Add(id, mileage, changeDetails, change_consumables);
            }
            mySqlDataReader.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddBusTS().Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBusTS.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите элемент для удаления");
                    return;
                }
                int idTS = int.Parse(dataGridViewBusTS.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `ts_bus` where `id`={idTS}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewBusTS();
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

        private void buttonShowBus_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBus().Show();
        }

        private void FormBusTS_Load(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewBusTS();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при загрузке данных");
                return;
            }
        }
    }
}
