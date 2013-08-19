namespace AutoClicker
{
    partial class AutoClicker
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
            this.autocast_button = new System.Windows.Forms.Button();
            this.frequency = new System.Windows.Forms.TextBox();
            this.hold = new System.Windows.Forms.TextBox();
            this.freq_label = new System.Windows.Forms.Label();
            this.hold_label = new System.Windows.Forms.Label();
            this.stop_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // autocast_button
            // 
            this.autocast_button.Location = new System.Drawing.Point(134, 107);
            this.autocast_button.Name = "autocast_button";
            this.autocast_button.Size = new System.Drawing.Size(75, 23);
            this.autocast_button.TabIndex = 0;
            this.autocast_button.Text = "Start";
            this.autocast_button.UseVisualStyleBackColor = true;
            this.autocast_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // frequency
            // 
            this.frequency.Location = new System.Drawing.Point(28, 70);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(100, 20);
            this.frequency.TabIndex = 1;
            this.frequency.Text = "1";
            // 
            // hold
            // 
            this.hold.Location = new System.Drawing.Point(134, 70);
            this.hold.Name = "hold";
            this.hold.Size = new System.Drawing.Size(100, 20);
            this.hold.TabIndex = 2;
            this.hold.Text = "1";
            // 
            // freq_label
            // 
            this.freq_label.AutoSize = true;
            this.freq_label.Location = new System.Drawing.Point(25, 54);
            this.freq_label.Name = "freq_label";
            this.freq_label.Size = new System.Drawing.Size(86, 13);
            this.freq_label.TabIndex = 3;
            this.freq_label.Text = "Click Frequency:";
            // 
            // hold_label
            // 
            this.hold_label.AutoSize = true;
            this.hold_label.Location = new System.Drawing.Point(131, 54);
            this.hold_label.Name = "hold_label";
            this.hold_label.Size = new System.Drawing.Size(68, 13);
            this.hold_label.TabIndex = 4;
            this.hold_label.Text = "Hold Length:";
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(53, 107);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(75, 23);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // AutoClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.hold_label);
            this.Controls.Add(this.freq_label);
            this.Controls.Add(this.hold);
            this.Controls.Add(this.frequency);
            this.Controls.Add(this.autocast_button);
            this.Name = "AutoClicker";
            this.Text = "AutoClicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button autocast_button;
        private System.Windows.Forms.TextBox frequency;
        private System.Windows.Forms.TextBox hold;
        private System.Windows.Forms.Label freq_label;
        private System.Windows.Forms.Label hold_label;
        private System.Windows.Forms.Button stop_button;
    }
}

