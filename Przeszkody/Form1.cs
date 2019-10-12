using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przeszk1
{
    public partial class Form1 : Form
    {
        Color kolorPrzeszkody = Color.DarkOliveGreen, kolorSterownika = Color.Crimson;
        bool zmienna;
        Control.ControlCollection pola;
        Random losowe = new Random();
        int pozycja;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j < 11; j++)
                for (int i = 0; i < 5; i++)
                {
                    TextBox pole = new TextBox();
                    pole.Width = 70;
                    pole.Left = i * 75 + 10;
                    pole.Top = j * 30 + 10;
                    pole.Enabled = false;
                    this.pnlPanel.Controls.Add(pole);
                }
        }

        private void PnlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval =(int) (timer1.Interval * 0.99);
            for (int i = 54; i > 4; i--)
                pola[i].BackColor = pola[i - 5].BackColor;
            for (int i = 0; i < 5; i++)
                pola[i].BackColor = SystemColors.Window;
            zmienna = !zmienna;
            if (pola[pozycja + 50].BackColor == kolorPrzeszkody)
            {
                pola[pozycja + 50].BackColor = Color.Black;
                timer1.Enabled = false;
                MessageBox.Show("Game Over");
            }
            else
                pola[pozycja + 50].BackColor = kolorSterownika;
            if (zmienna)
            {
                for (int i = 0; i < 4; i++)
                    pola[losowe.Next(0, 5)].BackColor = kolorPrzeszkody;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pola[pozycja + 50].BackColor = SystemColors.Window;
            if (e.KeyCode == Keys.Left && pozycja>0 && pola[pozycja + 50 - 1].BackColor != kolorPrzeszkody)
                    pozycja--;
                if (e.KeyCode == Keys.Right && pozycja<4 && pola[pozycja + 50 + 1].BackColor != kolorPrzeszkody)
                    pozycja++;
            pola[pozycja + 50].BackColor = kolorSterownika;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;  
            pola = this.pnlPanel.Controls;
            timer1.Enabled = true;
            pozycja = 2;
            pola[pozycja + 50].BackColor = kolorSterownika;
            
        }
    }
}
