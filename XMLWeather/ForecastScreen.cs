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
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            cityOutput.Text = Form1.days[0].location;

            date1.Text = Form1.days[1].date;
            min1.Text = Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + " °C";
            max1.Text = Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + " °C";
            displayCondition(1);

            date2.Text = Form1.days[2].date;
            min2.Text = Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + " °C";
            max2.Text = Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + " °C";
            displayCondition(2);

            date3.Text = Form1.days[3].date;
            min3.Text = Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + " °C";
            max3.Text = Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + " °C";
            displayCondition(3);
        }

        public void displayCondition(int value)
        {
            if (Convert.ToDouble(Form1.days[value].condition) <= 200 && Convert.ToDouble(Form1.days[value].condition) <= 232)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.thunder;
                    condition1.Text = "Thunder";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.thunder;
                    condition2.Text = "Thunder";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.thunder;
                    condition3.Text = "Thunder";
                }
            }

            else if (Convert.ToDouble(Form1.days[value].condition) <= 300 && Convert.ToDouble(Form1.days[value].condition) <= 321)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.drizzle;
                    condition1.Text = "Drizzle";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.drizzle;
                    condition2.Text = "Drizzle";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.drizzle;
                    condition3.Text = "Drizzle";
                }
            }
            else if (Convert.ToDouble(Form1.days[value].condition) <= 500 && Convert.ToDouble(Form1.days[value].condition) <= 531)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.rain;
                    condition1.Text = "Rain";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.rain;
                    condition2.Text = "Rain";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.rain;
                    condition3.Text = "Rain";
                }
            }
            else if (Convert.ToDouble(Form1.days[value].condition) <= 600 && Convert.ToDouble(Form1.days[value].condition) <= 622)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.snow;
                    condition1.Text = "Snow";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.snow;
                    condition2.Text = "Snow";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.snow;
                    condition3.Text = "Snow";
                }
            }
            else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.clear;
                    condition1.Text = "Clear";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.clear;
                    condition2.Text = "Clear";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.clear;
                    condition3.Text = "Clear";
                }
            }
            else if (Convert.ToDouble(Form1.days[value].condition) <= 800 && Convert.ToDouble(Form1.days[value].condition) <= 804)
            {
                if (value == 1)
                {
                    picture1.BackgroundImage = Properties.Resources.cloudy;
                    condition1.Text = "Cloudy";
                }
                if (value == 2)
                {
                    picture2.BackgroundImage = Properties.Resources.cloudy;
                    condition2.Text = "Cloudy";
                }
                if (value == 3)
                {
                    picture3.BackgroundImage = Properties.Resources.cloudy;
                    condition3.Text = "Cloudy";
                }
            }
            Refresh();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
