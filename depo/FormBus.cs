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
    public partial class FormBus : Form
    {
        MySqlCommand mySqlCommand;
        MySqlDataReader mySqlDataReader;
        MySqlConnection connection;

        public FormBus()
        {
            InitializeComponent();
        }

        private void FillDataGridViewBus()
        {
            string connectionString = "Server = localhost; Port = 3306; User = root; Password = 1234; Database = depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;

            mySqlCommand.CommandText = "Select * from `bus`";
            MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
            dataGridViewBus.Rows.Clear();

            while (mySqlDataReader.Read())
            {
                int id = mySqlDataReader.GetInt32("id");
                string type = mySqlDataReader.GetString("type");
                string model = mySqlDataReader.GetString("model");
                DateTime dateTime = mySqlDataReader.GetDateTime("date_ts");
                int sittingCount = mySqlDataReader.GetInt32("sitting_count");
                int id_ts = mySqlDataReader.GetInt32("id_ts");

                dataGridViewBus.Rows.Add(id, type, model, dateTime, sittingCount, id_ts);
            }
            mySqlDataReader.Close();
        }

        private void FormBus_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

            connection = new MySqlConnection(connectionString);
            connection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = connection;
            FillDataGridViewBus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormAddBus().Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBus.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Выберите данные для удаления");
                    return;
                }
                int idService = int.Parse(dataGridViewBus.SelectedRows[0].Cells[0].Value.ToString());

                mySqlCommand.CommandText = $"Delete from `bus` where `id`={idService}";
                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись успешно удалена");
                FillDataGridViewBus();
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

        private void buttonTS_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBusTS().Show();
        }
    }
}
