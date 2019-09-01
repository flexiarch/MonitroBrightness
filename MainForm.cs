using Hardware;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorController
{
    public partial class MainForm : Form
    {
        const string yes = "yes", no = "no";
        public MainForm()
        {
            InitializeComponent();
        }

        private async void OnButtonLoadClick(object sender, EventArgs e)
        {
            var monitors = Monitor.GetMonitors().ToArray();
            btnLoadMonitors.Enabled = false;
            LstMonitors.Items.Clear();
            LstMonitors.Items.Add("Collecting hardware informations...");
            await Task.WhenAll(monitors.Select(t => t.LoadAsync()).ToArray());
            LstMonitors.Items.Clear();
            btnLoadMonitors.Enabled = true;
            LstMonitors.Items.AddRange( monitors );
        }

        private void LstMonitors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = ((Monitor)LstMonitors.SelectedItem);
            if (selected == null) return;
            lblSupportsDdcValue.Text = selected.IsMonitorSupportDDC ? yes : no;
            lblSupportsBrightnessValue.Text = selected.IsBrightnessSupported ? yes : no;
            lblBrightnessMaximumValue.Text = selected.MaximumBrightness.ToString();
            lblBrightnessMinimumValue.Text = selected.MinimumBrightness.ToString();
            lblCurrentBrightnessValue.Text = selected.Brightness.ToString();
            if (!selected.IsMonitorSupportDDC || !selected.IsBrightnessSupported)
            {
                tbrBrightness.Enabled = false;
            }
            else
            {
                tbrBrightness.Enabled = true;
            }
            tbrBrightness.Minimum = selected.MinimumBrightness;
            tbrBrightness.Maximum = selected.MaximumBrightness;
            tbrBrightness.ValueChanged -= TrackBar1_ValueChanged;
            tbrBrightness.Value   = selected.Brightness;
            tbrBrightness.ValueChanged += TrackBar1_ValueChanged;
        }

        private async void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            var selected = ((Monitor)LstMonitors.SelectedItem);
            await selected.SetBrightness(tbrBrightness.Value);
            lblCurrentBrightnessValue.Text = selected.Brightness.ToString();
        }
    }
}
