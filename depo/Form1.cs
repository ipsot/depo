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
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void buttonBus_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormBus().Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDriver_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormDriver().Show();
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRoute().Show();
        }

        private void buttonVoyage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormVoyage().Show();
        }
    }
}
