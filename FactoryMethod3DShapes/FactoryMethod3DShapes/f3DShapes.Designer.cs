namespace FactoryMethod3DShapes
{
    partial class f3DShapes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxShapeImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb3DShapeType = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShapeImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(660, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 686);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(19, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose 3D Shape";
            // 
            // pbxShapeImage
            // 
            this.pbxShapeImage.BackColor = System.Drawing.Color.LightPink;
            this.pbxShapeImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxShapeImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxShapeImage.Location = new System.Drawing.Point(0, 0);
            this.pbxShapeImage.Margin = new System.Windows.Forms.Padding(100);
            this.pbxShapeImage.Name = "pbxShapeImage";
            this.pbxShapeImage.Size = new System.Drawing.Size(660, 686);
            this.pbxShapeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxShapeImage.TabIndex = 1;
            this.pbxShapeImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.rb3DShapeType);
            this.panel2.Location = new System.Drawing.Point(19, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 267);
            this.panel2.TabIndex = 1;
            // 
            // rb3DShapeType
            // 
            this.rb3DShapeType.AutoSize = true;
            this.rb3DShapeType.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.rb3DShapeType.ForeColor = System.Drawing.Color.Indigo;
            this.rb3DShapeType.Location = new System.Drawing.Point(15, 23);
            this.rb3DShapeType.Name = "rb3DShapeType";
            this.rb3DShapeType.Size = new System.Drawing.Size(148, 40);
            this.rb3DShapeType.TabIndex = 0;
            this.rb3DShapeType.TabStop = true;
            this.rb3DShapeType.Text = "Sphere";
            this.rb3DShapeType.UseVisualStyleBackColor = true;
            this.rb3DShapeType.CheckedChanged += new System.EventHandler(this.rb3DShapeType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.radioButton2.ForeColor = System.Drawing.Color.Indigo;
            this.radioButton2.Location = new System.Drawing.Point(15, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(142, 40);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cuboid";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rb3DShapeType_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Snap ITC", 16.2F);
            this.radioButton3.ForeColor = System.Drawing.Color.Indigo;
            this.radioButton3.Location = new System.Drawing.Point(15, 193);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(111, 40);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Cone";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rb3DShapeType_CheckedChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Plum;
            this.btnCreate.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Purple;
            this.btnCreate.Location = new System.Drawing.Point(19, 590);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(290, 83);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // f3DShapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(997, 686);
            this.Controls.Add(this.pbxShapeImage);
            this.Controls.Add(this.panel1);
            this.Name = "f3DShapes";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxShapeImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxShapeImage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rb3DShapeType;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnCreate;
    }
}

