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
        
        private NewTicketWindow newTicketWindow;

        public TowsWindow()
        {
            InitializeComponent();
            PopulateTicketGrid();
            TruckPanel.Visible = false;
        }
        private void TruckButton_Click(object sender, EventArgs e)
        {
            TowSplitContainer.Visible = false;
            TruckPanel.Visible = true;

        }

        private void TowButton_Click(object sender, EventArgs e)
        {
            TowSplitContainer.Visible = true;
            TruckPanel.Visible = false;
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
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Populate the text boxes with data from the selected row
                TicketNumTW.Text = selectedRow.Cells["TicketNumber"].Value.ToString();
                DriverNameTW.Text = selectedRow.Cells["DriverName"].Value.ToString();
                TruckNumTW.Text = selectedRow.Cells["TruckNum"].Value.ToString();
                PuTimeTW.Text = selectedRow.Cells["PickUpTime"].Value.ToString();
                DoTimeTW.Text = selectedRow.Cells["DropOffTime"].Value.ToString();
                PickUpDateTW.Text = selectedRow.Cells["PickUpDate"].Value.ToString();
                DropOffDateTW.Text = selectedRow.Cells["DropOffDate"].Value.ToString();
                PuLocTW.Text = selectedRow.Cells["PickUpLocation"].Value.ToString();
                DoLocTW.Text = selectedRow.Cells["DropOffLocation"].Value.ToString();
                estCostTW.Text = selectedRow.Cells["EstimatedCost"].Value.ToString();
                custNameTW.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                custEmailTW.Text = selectedRow.Cells["CustomerEmail"].Value.ToString();
                custPhoneTW.Text = selectedRow.Cells["CustomerPhone"].Value.ToString();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
