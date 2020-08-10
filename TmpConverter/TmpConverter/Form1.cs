using System;
using System.Windows.Forms;

namespace TmpConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CelsiusNumUpDown.Value = 100;
        }

        private void CelsiusNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal celsiusValue = CelsiusNumUpDown.Value;

            FahrenheitNumUpDown.Value = celsiusValue * 1.8m + 32;
            KelvinNumUpDown.Value = celsiusValue + 273.15m;
        }

        private void FahrenheitNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal fahrenheitValue = FahrenheitNumUpDown.Value;

            CelsiusNumUpDown.Value = (fahrenheitValue - 32) / 1.8m;
            KelvinNumUpDown.Value = (fahrenheitValue - 32) / 1.8m + 273.15m;
        }

        private void KelvinNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal kelvinValue = KelvinNumUpDown.Value;

            CelsiusNumUpDown.Value = kelvinValue - 273.15m;
            FahrenheitNumUpDown.Value = kelvinValue * 1.8m - 459.67m;
        }
    }
}
