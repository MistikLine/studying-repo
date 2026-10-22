namespace SingletonPattern_Schedule
{
    partial class MainMenu
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
            this.rtxtLogs = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadLogs = new System.Windows.Forms.Button();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxtLogs
            // 
            this.rtxtLogs.Location = new System.Drawing.Point(360, 55);
            this.rtxtLogs.Name = "rtxtLogs";
            this.rtxtLogs.ReadOnly = true;
            this.rtxtLogs.Size = new System.Drawing.Size(548, 475);
            this.rtxtLogs.TabIndex = 0;
            this.rtxtLogs.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(583, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логер";
            // 
            // btnLoadLogs
            // 
            this.btnLoadLogs.BackColor = System.Drawing.Color.PaleGreen;
            this.btnLoadLogs.Location = new System.Drawing.Point(360, 536);
            this.btnLoadLogs.Name = "btnLoadLogs";
            this.btnLoadLogs.Size = new System.Drawing.Size(156, 53);
            this.btnLoadLogs.TabIndex = 2;
            this.btnLoadLogs.Text = "Завантажити Логи";
            this.btnLoadLogs.UseVisualStyleBackColor = false;
            this.btnLoadLogs.Click += new System.EventHandler(this.btnLoadLogs_Click);
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSaveLogs.Location = new System.Drawing.Point(755, 536);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(153, 53);
            this.btnSaveLogs.TabIndex = 3;
            this.btnSaveLogs.Text = "Зберегти Логи";
            this.btnSaveLogs.UseVisualStyleBackColor = false;
            this.btnSaveLogs.Click += new System.EventHandler(this.btnSaveLogs_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSchedule.Location = new System.Drawing.Point(25, 156);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(312, 61);
            this.btnSchedule.TabIndex = 4;
            this.btnSchedule.Text = "Побачити Розклад";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClose.Location = new System.Drawing.Point(25, 401);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(312, 61);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Вийти";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SingletonPattern_Schedule.Properties.Resources.youtube_header_fox_sleeping;
            this.pictureBox1.Location = new System.Drawing.Point(25, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(920, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.btnLoadLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtLogs);
            this.Name = "MainMenu";
            this.Text = "Головне меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadLogs;
        private System.Windows.Forms.Button btnSaveLogs;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

