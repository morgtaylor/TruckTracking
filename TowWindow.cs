using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckTracking
{
    public partial class TowsWindow : Form
    {
        private TruckWindow truckWindow;
        private NewTicketWindow newTicketWindow;

        public TowsWindow()
        {
            InitializeComponent();

        }
        private void TruckButton_Click(object sender, EventArgs e)
        {
            truckWindow = new TruckWindow();
            truckWindow.Panel1.Show();
            splitContainer1.Visible = false;

        }

        private void TowButton_Click(object sender, EventArgs e)
        {
            splitContainer1.Visible = true;
        }

        private void NewTicketButton_Click(object sender, EventArgs e)
        {
            newTicketWindow = new NewTicketWindow();
            newTicketWindow.Show();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void DoTime_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
