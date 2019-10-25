namespace Przeszk1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.timerlabel = new System.Windows.Forms.Label();
            this.resetbutton = new System.Windows.Forms.Button();
            this.highscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlPanel
            // 
            this.pnlPanel.Location = new System.Drawing.Point(2, 2);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(390, 340);
            this.pnlPanel.TabIndex = 0;
            this.pnlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPanel_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // gametime
            // 
            this.gametime.Tick += new System.EventHandler(this.gametime_Tick);
            // 
            // timerlabel
            // 
            this.timerlabel.Location = new System.Drawing.Point(308, 351);
            this.timerlabel.Name = "timerlabel";
            this.timerlabel.Size = new System.Drawing.Size(74, 23);
            this.timerlabel.TabIndex = 2;
            this.timerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetbutton
            // 
            this.resetbutton.Location = new System.Drawing.Point(94, 351);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(75, 23);
            this.resetbutton.TabIndex = 3;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = true;
            this.resetbutton.Visible = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // highscore
            // 
            this.highscore.AutoSize = true;
            this.highscore.Location = new System.Drawing.Point(203, 356);
            this.highscore.Name = "highscore";
            this.highscore.Size = new System.Drawing.Size(0, 13);
            this.highscore.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 386);
            this.Controls.Add(this.highscore);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.timerlabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Przeszkody";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.Label timerlabel;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label highscore;
    }
}

