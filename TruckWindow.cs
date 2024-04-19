using System.Windows.Forms;

namespace TruckTracking
{
    public partial class TruckWindow : Form
    {
        public Panel Panel1 { get { return panel1; } }
        public TruckWindow()
        {
            InitializeComponent();
            panel1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
