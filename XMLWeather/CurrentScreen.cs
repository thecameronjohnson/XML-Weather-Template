using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            tempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") +" °C";
            minOutput.Text = Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + " °C";
            maxOutput.Text = Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + " °C";
            dateLabel.Text = Form1.days[0].date;
            displayCondition();
        }

        public void displayCondition()
        {
            if (Convert.ToDouble(Form1.days[0].condition) <= 200 && Convert.ToDouble(Form1.days[0].condition) <= 232)
            {
                imageOutput.BackgroundImage = Properties.Resources.thunder;
                conditionLabel.Text = "Thunder";
            }

            else if (Convert.ToDouble(Form1.days[0].condition) <= 300 && Convert.ToDouble(Form1.days[0].condition) <= 321)
            {
                imageOutput.BackgroundImage = Properties.Resources.drizzle;
                conditionLabel.Text = "Drizzle";
            }
            else if (Convert.ToDouble(Form1.days[0].condition) <= 500 && Convert.ToDouble(Form1.days[0].condition) <= 531)
            {
                imageOutput.BackgroundImage = Properties.Resources.rain;
                conditionLabel.Text = "Rain";
            }
            else if (Convert.ToDouble(Form1.days[0].condition) <= 600 && Convert.ToDouble(Form1.days[0].condition) <= 622)
            {
                imageOutput.BackgroundImage = Properties.Resources.snow;
                conditionLabel.Text = "Snow";
            }
            else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                imageOutput.BackgroundImage = Properties.Resources.clear;
                conditionLabel.Text = "Clear";
            }
            else if (Convert.ToDouble(Form1.days[0].condition) <= 800 && Convert.ToDouble(Form1.days[0].condition) <= 804)
            {
                imageOutput.BackgroundImage = Properties.Resources.cloudy;
                conditionLabel.Text = "Cloudy";
            }
            Refresh();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void cityOutput_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
