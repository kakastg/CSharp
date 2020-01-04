namespace ProjectForm
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.GameTimeBox = new System.Windows.Forms.TextBox();
            this.GameTime = new System.Windows.Forms.Timer(this.components);
            this.pnlPanel = new System.Windows.Forms.Panel();
            this.SwitchingTimer = new System.Windows.Forms.Timer(this.components);
            this.DebugLabel = new System.Windows.Forms.Label();
            this.TickTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 415);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click_1);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(93, 415);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "Finish";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click_1);
            // 
            // GameTimeBox
            // 
            this.GameTimeBox.Location = new System.Drawing.Point(174, 417);
            this.GameTimeBox.Name = "GameTimeBox";
            this.GameTimeBox.Size = new System.Drawing.Size(100, 20);
            this.GameTimeBox.TabIndex = 2;
            // 
            // GameTime
            // 
            this.GameTime.Interval = 1000;
            this.GameTime.Tick += new System.EventHandler(this.GameTime_Tick_1);
            // 
            // pnlPanel
            // 
            this.pnlPanel.BackColor = System.Drawing.Color.Transparent;
            this.pnlPanel.Location = new System.Drawing.Point(12, 12);
            this.pnlPanel.Name = "pnlPanel";
            this.pnlPanel.Size = new System.Drawing.Size(757, 400);
            this.pnlPanel.TabIndex = 3;
            this.pnlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPanel_Paint);
            // 
            // SwitchingTimer
            // 
            this.SwitchingTimer.Interval = 2000;
            this.SwitchingTimer.Tick += new System.EventHandler(this.SwitchingTimer_Tick);
            // 
            // DebugLabel
            // 
            this.DebugLabel.AutoSize = true;
            this.DebugLabel.Location = new System.Drawing.Point(290, 420);
            this.DebugLabel.Name = "DebugLabel";
            this.DebugLabel.Size = new System.Drawing.Size(36, 13);
            this.DebugLabel.TabIndex = 4;
            this.DebugLabel.Text = "Points";
            // 
            // TickTime
            // 
            this.TickTime.AutoSize = true;
            this.TickTime.Location = new System.Drawing.Point(345, 420);
            this.TickTime.Name = "TickTime";
            this.TickTime.Size = new System.Drawing.Size(82, 13);
            this.TickTime.TabIndex = 5;
            this.TickTime.Text = "Switching Timer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.TickTime);
            this.Controls.Add(this.DebugLabel);
            this.Controls.Add(this.pnlPanel);
            this.Controls.Add(this.GameTimeBox);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox GameTimeBox;
        private System.Windows.Forms.Timer GameTime;
        private System.Windows.Forms.Panel pnlPanel;
        private System.Windows.Forms.Timer SwitchingTimer;
        private System.Windows.Forms.Label DebugLabel;
        private System.Windows.Forms.Label TickTime;
    }
}

