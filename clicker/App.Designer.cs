namespace clicker
{
    partial class App
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.PollingTextBox = new System.Windows.Forms.TextBox();
            this.PollingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(46, 36);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(273, 57);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(46, 119);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(273, 56);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // PollingTextBox
            // 
            this.PollingTextBox.Location = new System.Drawing.Point(353, 54);
            this.PollingTextBox.Name = "PollingTextBox";
            this.PollingTextBox.Size = new System.Drawing.Size(100, 23);
            this.PollingTextBox.TabIndex = 1;
            this.PollingTextBox.Text = "60000";
            // 
            // PollingLabel
            // 
            this.PollingLabel.AutoSize = true;
            this.PollingLabel.Location = new System.Drawing.Point(353, 36);
            this.PollingLabel.Name = "PollingLabel";
            this.PollingLabel.Size = new System.Drawing.Size(72, 15);
            this.PollingLabel.TabIndex = 2;
            this.PollingLabel.Text = "Polling (MS)";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.PollingLabel);
            this.Controls.Add(this.PollingTextBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Name = "App";
            this.Text = "Clicker";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox PollingTextBox;
        private System.Windows.Forms.Label PollingLabel;
    }
}

