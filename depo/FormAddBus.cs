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
    public partial class FormAddBus : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;

        List<tsBus> tsBuses;
        public FormAddBus()
        {
            InitializeComponent();
        }

        private void LoadTS()
        {
            mySqlCommand.CommandText = "select* from `ts_bus`";

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                int mileage = reader.GetInt32("mileage");
                string change_details = reader.GetString("change_details");
                string change_consumables = reader.GetString("change_consumables");

                tsBuses.Add(new tsBus()
                {
                    id = id,
                    Mileage = mileage,
                    ChangeDetails = change_details,
                    Change_Consumables = change_consumables,
                });

            }
            reader.Close();
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

                List<tsBus> tsBuses;

                int ts = ((tsBus)comboBoxIdTS.SelectedItem).id;

                if (textBox1.Text == null || textBox2.Text==null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }

                DateTime dt = dateTimePicker1.Value;
                DateTime dateTime = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
                string date = dateTime.ToString("yyyy-MM-dd H:mm:ss");

                //int sum = price * count;
                //textBoxItogo.Text = $"{sum}";
                //int idGenre = ((Genres)(comboBoxGenre.SelectedItem)).Id;


                mySqlCommand.CommandText = $"insert into `bus` (`id`,`type`,`model`,`date_ts`, `sitting_count`, `id_ts`) values (0,'{textBox1.Text}','{textBox2.Text}','{date}',{maskedTextBox1.Text},'{ts}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormBus().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBus().Show();
        }

        private void FormAddBus_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

            mySqlConnection = new MySqlConnection(connectionString);
            mySqlConnection.Open();

            mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = mySqlConnection;


            tsBuses = new List<tsBus>();

            try
            {
                LoadTS();
                comboBoxIdTS.DataSource = tsBuses;
                comboBoxIdTS.DisplayMember = "id";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
