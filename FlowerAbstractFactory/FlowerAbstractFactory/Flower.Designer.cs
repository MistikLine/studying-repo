namespace FlowerAbstractFactory
{
    partial class fFlower
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
            this.pFlowerType = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbFlowerType = new System.Windows.Forms.RadioButton();
            this.pFlower = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbFlower = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRose = new System.Windows.Forms.Label();
            this.pbxViolet = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pbxChamomile = new System.Windows.Forms.PictureBox();
            this.pbxRose = new System.Windows.Forms.PictureBox();
            this.lbViolet = new System.Windows.Forms.Label();
            this.lbChamomile = new System.Windows.Forms.Label();
            this.pFlowerType.SuspendLayout();
            this.pFlower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChamomile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRose)).BeginInit();
            this.SuspendLayout();
            // 
            // pFlowerType
            // 
            this.pFlowerType.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFlowerType.Controls.Add(this.radioButton3);
            this.pFlowerType.Controls.Add(this.radioButton2);
            this.pFlowerType.Controls.Add(this.label2);
            this.pFlowerType.Controls.Add(this.rbFlowerType);
            this.pFlowerType.Dock = System.Windows.Forms.DockStyle.Left;
            this.pFlowerType.Location = new System.Drawing.Point(0, 0);
            this.pFlowerType.Name = "pFlowerType";
            this.pFlowerType.Size = new System.Drawing.Size(192, 531);
            this.pFlowerType.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.radioButton3.Location = new System.Drawing.Point(8, 290);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(122, 28);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Wild";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbFlowerType_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.radioButton2.Location = new System.Drawing.Point(8, 212);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(160, 28);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Indoor";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbFlowerType_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // rbFlowerType
            // 
            this.rbFlowerType.AutoSize = true;
            this.rbFlowerType.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFlowerType.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbFlowerType.Location = new System.Drawing.Point(8, 134);
            this.rbFlowerType.Name = "rbFlowerType";
            this.rbFlowerType.Size = new System.Drawing.Size(164, 28);
            this.rbFlowerType.TabIndex = 0;
            this.rbFlowerType.TabStop = true;
            this.rbFlowerType.Tag = "1";
            this.rbFlowerType.Text = "Garden";
            this.rbFlowerType.UseVisualStyleBackColor = true;
            this.rbFlowerType.CheckedChanged += new System.EventHandler(this.rbFlowerType_CheckedChanged);
            // 
            // pFlower
            // 
            this.pFlower.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pFlower.Controls.Add(this.radioButton4);
            this.pFlower.Controls.Add(this.radioButton5);
            this.pFlower.Controls.Add(this.rbFlower);
            this.pFlower.Controls.Add(this.label3);
            this.pFlower.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFlower.Location = new System.Drawing.Point(817, 0);
            this.pFlower.Name = "pFlower";
            this.pFlower.Size = new System.Drawing.Size(282, 531);
            this.pFlower.TabIndex = 1;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.radioButton4.Location = new System.Drawing.Point(14, 290);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(116, 28);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Rose";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rbFlower_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.radioButton5.Location = new System.Drawing.Point(14, 212);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(159, 28);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Violet";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.rbFlower_CheckedChanged);
            // 
            // rbFlower
            // 
            this.rbFlower.AutoSize = true;
            this.rbFlower.Font = new System.Drawing.Font("Goudy Stout", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFlower.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.rbFlower.Location = new System.Drawing.Point(14, 134);
            this.rbFlower.Name = "rbFlower";
            this.rbFlower.Size = new System.Drawing.Size(242, 28);
            this.rbFlower.TabIndex = 7;
            this.rbFlower.TabStop = true;
            this.rbFlower.Text = "Chamomile";
            this.rbFlower.UseVisualStyleBackColor = true;
            this.rbFlower.CheckedChanged += new System.EventHandler(this.rbFlower_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(48, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Flower";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose what to create :3";
            // 
            // lbRose
            // 
            this.lbRose.AutoSize = true;
            this.lbRose.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRose.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbRose.Location = new System.Drawing.Point(369, 385);
            this.lbRose.Name = "lbRose";
            this.lbRose.Size = new System.Drawing.Size(39, 22);
            this.lbRose.TabIndex = 3;
            this.lbRose.Text = "Type";
            // 
            // pbxViolet
            // 
            this.pbxViolet.BackColor = System.Drawing.Color.Thistle;
            this.pbxViolet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxViolet.ImageLocation = "";
            this.pbxViolet.Location = new System.Drawing.Point(220, 43);
            this.pbxViolet.Name = "pbxViolet";
            this.pbxViolet.Size = new System.Drawing.Size(252, 173);
            this.pbxViolet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxViolet.TabIndex = 4;
            this.pbxViolet.TabStop = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnCreate.Font = new System.Drawing.Font("Goudy Stout", 13.8F);
            this.btnCreate.ForeColor = System.Drawing.Color.Thistle;
            this.btnCreate.Location = new System.Drawing.Point(220, 441);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(566, 64);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pbxChamomile
            // 
            this.pbxChamomile.BackColor = System.Drawing.Color.Thistle;
            this.pbxChamomile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxChamomile.ImageLocation = "";
            this.pbxChamomile.Location = new System.Drawing.Point(534, 44);
            this.pbxChamomile.Name = "pbxChamomile";
            this.pbxChamomile.Size = new System.Drawing.Size(252, 173);
            this.pbxChamomile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxChamomile.TabIndex = 6;
            this.pbxChamomile.TabStop = false;
            // 
            // pbxRose
            // 
            this.pbxRose.BackColor = System.Drawing.Color.Thistle;
            this.pbxRose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxRose.ImageLocation = "";
            this.pbxRose.Location = new System.Drawing.Point(373, 187);
            this.pbxRose.Name = "pbxRose";
            this.pbxRose.Size = new System.Drawing.Size(252, 185);
            this.pbxRose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRose.TabIndex = 7;
            this.pbxRose.TabStop = false;
            // 
            // lbViolet
            // 
            this.lbViolet.AutoSize = true;
            this.lbViolet.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViolet.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbViolet.Location = new System.Drawing.Point(215, 230);
            this.lbViolet.Name = "lbViolet";
            this.lbViolet.Size = new System.Drawing.Size(39, 22);
            this.lbViolet.TabIndex = 8;
            this.lbViolet.Text = "Type";
            // 
            // lbChamomile
            // 
            this.lbChamomile.AutoSize = true;
            this.lbChamomile.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChamomile.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbChamomile.Location = new System.Drawing.Point(631, 230);
            this.lbChamomile.Name = "lbChamomile";
            this.lbChamomile.Size = new System.Drawing.Size(39, 22);
            this.lbChamomile.TabIndex = 9;
            this.lbChamomile.Text = "Type";
            // 
            // fFlower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(1099, 531);
            this.Controls.Add(this.lbChamomile);
            this.Controls.Add(this.lbViolet);
            this.Controls.Add(this.pbxRose);
            this.Controls.Add(this.pbxChamomile);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pbxViolet);
            this.Controls.Add(this.lbRose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pFlower);
            this.Controls.Add(this.pFlowerType);
            this.Name = "fFlower";
            this.Text = "To Create Flowers :3";
            this.pFlowerType.ResumeLayout(false);
            this.pFlowerType.PerformLayout();
            this.pFlower.ResumeLayout(false);
            this.pFlower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxViolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxChamomile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pFlowerType;
        private System.Windows.Forms.RadioButton rbFlowerType;
        private System.Windows.Forms.Panel pFlower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbFlower;
        private System.Windows.Forms.Label lbRose;
        private System.Windows.Forms.PictureBox pbxViolet;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pbxChamomile;
        private System.Windows.Forms.PictureBox pbxRose;
        private System.Windows.Forms.Label lbViolet;
        private System.Windows.Forms.Label lbChamomile;
    }
}

