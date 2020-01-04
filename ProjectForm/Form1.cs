using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForm
{
    public partial class Form1 : Form
    {
        int seconds = 0;
        Control.ControlCollection pola;
        Random random = new Random();
        int points = 0;

        public Control.ControlCollection Pola { get => pola; set => pola = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            GameTime.Enabled = false;
            GameTimeBox.Enabled = false;
            EndButton.Enabled = false;
            for (int j = 0; j < 7; j++)
                for (int i = 0; i < 7; i++)
                {
                    Button pole = new Button();
                    pole.Width = 70;
                    pole.Left = i * 110 + 10;
                    pole.Top = j * 55 + 10;
                    pole.Enabled = true;
                    pole.Visible = false;
                    pole.Click += Pole_Click;
                    this.pnlPanel.Controls.Add(pole);
                }
        }

        private void Pole_Click(object sender, EventArgs e)
        {
            points++;
            DebugLabel.Text = points.ToString();
            for (int i = 0; i < 49; i++)
            {
                pola[i].Visible = false;
            }
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            GameTime.Enabled = true;
            StartButton.Enabled = false;
            EndButton.Enabled = true;
            SwitchingTimer.Enabled = true;

            pola = this.pnlPanel.Controls;
        }

        private void EndButton_Click_1(object sender, EventArgs e)
        {
            GameTimeBox.Text = seconds.ToString() + " seconds";
            GameTime.Enabled = false;
            seconds = 0;
            StartButton.Enabled = true;
            EndButton.Enabled = false;
            SwitchingTimer.Enabled = false;
        }

        private void GameTime_Tick_1(object sender, EventArgs e)
        {
            ++seconds;
        }

        private void pnlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwitchingTimer_Tick(object sender, EventArgs e)
        {
            if (SwitchingTimer.Interval < 800)
                SwitchingTimer.Interval = 800;
            else
                SwitchingTimer.Interval = (int)(SwitchingTimer.Interval * 0.99);
            for (int i = 0; i < 49; i++)
            {
                pola[i].Visible = false;
            }
            int losowy = random.Next(0, 49);
            pola[losowy].Visible = true;
            TickTime.Text = SwitchingTimer.Interval.ToString();
        }
    }
}

