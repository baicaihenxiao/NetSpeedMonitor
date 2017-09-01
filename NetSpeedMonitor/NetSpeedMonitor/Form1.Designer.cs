namespace NetSpeedMonitor
{
    partial class MainForm
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
            this.labelUp = new System.Windows.Forms.Label();
            this.labelUploadSpeed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelUp
            // 
            this.labelUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUp.AutoSize = true;
            this.labelUp.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUp.Location = new System.Drawing.Point(5, 4);
            this.labelUp.Margin = new System.Windows.Forms.Padding(0);
            this.labelUp.Name = "labelUp";
            this.labelUp.Size = new System.Drawing.Size(23, 15);
            this.labelUp.TabIndex = 0;
            this.labelUp.Text = "Up";
            this.labelUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUploadSpeed
            // 
            this.labelUploadSpeed.AutoSize = true;
            this.labelUploadSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labelUploadSpeed.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUploadSpeed.Location = new System.Drawing.Point(32, 4);
            this.labelUploadSpeed.Name = "labelUploadSpeed";
            this.labelUploadSpeed.Size = new System.Drawing.Size(78, 20);
            this.labelUploadSpeed.TabIndex = 1;
            this.labelUploadSpeed.Text = "0.0KiB/s";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 24);
            this.Controls.Add(this.labelUploadSpeed);
            this.Controls.Add(this.labelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUp;
        private System.Windows.Forms.Label labelUploadSpeed;
        private System.Windows.Forms.Timer timer1;
    }
}

