namespace FlyweightPattern
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
            this.pbxField = new System.Windows.Forms.PictureBox();
            this.rbtnRose = new System.Windows.Forms.RadioButton();
            this.rbtnViolet = new System.Windows.Forms.RadioButton();
            this.rbtnSpiderLily = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxField)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxField
            // 
            this.pbxField.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pbxField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxField.Location = new System.Drawing.Point(315, 30);
            this.pbxField.Name = "pbxField";
            this.pbxField.Size = new System.Drawing.Size(678, 507);
            this.pbxField.TabIndex = 0;
            this.pbxField.TabStop = false;
            this.pbxField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxField_MouseUp);
            // 
            // rbtnRose
            // 
            this.rbtnRose.AutoSize = true;
            this.rbtnRose.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRose.Location = new System.Drawing.Point(16, 30);
            this.rbtnRose.Name = "rbtnRose";
            this.rbtnRose.Size = new System.Drawing.Size(127, 48);
            this.rbtnRose.TabIndex = 1;
            this.rbtnRose.TabStop = true;
            this.rbtnRose.Text = "Rose";
            this.rbtnRose.UseVisualStyleBackColor = true;
            // 
            // rbtnViolet
            // 
            this.rbtnViolet.AutoSize = true;
            this.rbtnViolet.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViolet.Location = new System.Drawing.Point(16, 84);
            this.rbtnViolet.Name = "rbtnViolet";
            this.rbtnViolet.Size = new System.Drawing.Size(154, 48);
            this.rbtnViolet.TabIndex = 2;
            this.rbtnViolet.TabStop = true;
            this.rbtnViolet.Text = "Violet";
            this.rbtnViolet.UseVisualStyleBackColor = true;
            // 
            // rbtnSpiderLily
            // 
            this.rbtnSpiderLily.AutoSize = true;
            this.rbtnSpiderLily.Font = new System.Drawing.Font("Lucida Calligraphy", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSpiderLily.Location = new System.Drawing.Point(16, 138);
            this.rbtnSpiderLily.Name = "rbtnSpiderLily";
            this.rbtnSpiderLily.Size = new System.Drawing.Size(250, 48);
            this.rbtnSpiderLily.TabIndex = 3;
            this.rbtnSpiderLily.TabStop = true;
            this.rbtnSpiderLily.Text = "Spider Lily";
            this.rbtnSpiderLily.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1032, 566);
            this.Controls.Add(this.rbtnSpiderLily);
            this.Controls.Add(this.rbtnViolet);
            this.Controls.Add(this.rbtnRose);
            this.Controls.Add(this.pbxField);
            this.Name = "Form1";
            this.Text = "Plant flower";
            ((System.ComponentModel.ISupportInitialize)(this.pbxField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxField;
        private System.Windows.Forms.RadioButton rbtnRose;
        private System.Windows.Forms.RadioButton rbtnViolet;
        private System.Windows.Forms.RadioButton rbtnSpiderLily;
        private System.Windows.Forms.Timer timer;
    }
}

