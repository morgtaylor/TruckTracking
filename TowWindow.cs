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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the text boxes with data from the selected row
                TicketNum.Text = selectedRow.Cells["TicketNumber"].Value.ToString();
                DriverName.Text = selectedRow.Cells["DriverName"].Value.ToString();
                PuTime.Text = selectedRow.Cells["PickUpTime"].Value.ToString();
                DoTime.Text = selectedRow.Cells["DropOffTime"].Value.ToString();
                PickUpDate.Text = selectedRow.Cells["PickUpDate"].Value.ToString();
                DropOffDate.Text = selectedRow.Cells["DropOffDate"].Value.ToString();
                PuLoc.Text = selectedRow.Cells["PickUpLocation"].Value.ToString();
                DoLoc.Text = selectedRow.Cells["DropOffLocation"].Value.ToString();
                estCost.Text = selectedRow.Cells["EstimatedCost"].Value.ToString();
                custNameNT.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                custEmailNT.Text = selectedRow.Cells["CustomerEmail"].Value.ToString();
                custPhoneNT.Text = selectedRow.Cells["CustomerPhone"].Value.ToString();
            }
        }
    }
}
