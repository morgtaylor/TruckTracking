using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
            PopulateTicketGrid();

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
        private void PopulateTicketGrid()
        {
            string selectQuery = "SELECT * FROM Tickets";

            DataTable dataTable = new DataTable();

            using (var connection = new SQLiteConnection(Database.connectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView1.DataSource = dataTable;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StatusBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
