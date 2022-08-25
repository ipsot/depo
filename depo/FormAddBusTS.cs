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
    public partial class FormAddBusTS : Form
    {
        MySqlConnection mySqlConnection;
        MySqlCommand mySqlCommand;
        public FormAddBusTS()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "Server=localhost;Port=3306;User=root;Password=1234;Database=depo";

                mySqlConnection = new MySqlConnection(connectionString);
                mySqlConnection.Open();

                mySqlCommand = new MySqlCommand();
                mySqlCommand.Connection = mySqlConnection;


                if (maskedTextBoxMileage.Text == null || textBoxChangeDetails.Text == null || textBoxConsumbile.Text==null)
                {
                    MessageBox.Show("Пожайлуста заполните все поля");
                    return;
                }


                mySqlCommand.CommandText = $"insert into `ts_bus` (`id`,`mileage`,`change_details`,`change_consumables`) values (0,'{maskedTextBoxMileage.Text}','{textBoxChangeDetails.Text}','{textBoxConsumbile.Text}')";
                mySqlCommand.ExecuteNonQuery();


                this.Hide();
                new FormBusTS().Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка при добавлении");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBusTS().Show();
        }
    }
}
