namespace BuilderAndPrototypePattern
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pCreationPanel = new System.Windows.Forms.Panel();
            this.rtxtReport = new System.Windows.Forms.RichTextBox();
            this.btnCreateEmployeeReport = new System.Windows.Forms.Button();
            this.btnCreateTaskReport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chbCoverPage = new System.Windows.Forms.CheckBox();
            this.chbIntroduction = new System.Windows.Forms.CheckBox();
            this.chbMainBody = new System.Windows.Forms.CheckBox();
            this.chbConclusions = new System.Windows.Forms.CheckBox();
            this.chbReferences = new System.Windows.Forms.CheckBox();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pCreationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCreateTaskReport);
            this.panel1.Controls.Add(this.btnCreateEmployeeReport);
            this.panel1.Controls.Add(this.pCreationPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 635);
            this.panel1.TabIndex = 0;
            // 
            // pCreationPanel
            // 
            this.pCreationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pCreationPanel.Controls.Add(this.btnCreateReport);
            this.pCreationPanel.Controls.Add(this.chbReferences);
            this.pCreationPanel.Controls.Add(this.chbConclusions);
            this.pCreationPanel.Controls.Add(this.chbMainBody);
            this.pCreationPanel.Controls.Add(this.chbIntroduction);
            this.pCreationPanel.Controls.Add(this.chbCoverPage);
            this.pCreationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pCreationPanel.Location = new System.Drawing.Point(0, 186);
            this.pCreationPanel.Name = "pCreationPanel";
            this.pCreationPanel.Size = new System.Drawing.Size(283, 447);
            this.pCreationPanel.TabIndex = 0;
            this.pCreationPanel.Visible = false;
            // 
            // rtxtReport
            // 
            this.rtxtReport.Location = new System.Drawing.Point(305, 21);
            this.rtxtReport.Name = "rtxtReport";
            this.rtxtReport.Size = new System.Drawing.Size(777, 549);
            this.rtxtReport.TabIndex = 2;
            this.rtxtReport.Text = "";
            // 
            // btnCreateEmployeeReport
            // 
            this.btnCreateEmployeeReport.Location = new System.Drawing.Point(11, 20);
            this.btnCreateEmployeeReport.Name = "btnCreateEmployeeReport";
            this.btnCreateEmployeeReport.Size = new System.Drawing.Size(257, 53);
            this.btnCreateEmployeeReport.TabIndex = 1;
            this.btnCreateEmployeeReport.Text = "Створити звіт про робітників";
            this.btnCreateEmployeeReport.UseVisualStyleBackColor = true;
            this.btnCreateEmployeeReport.Click += new System.EventHandler(this.btnCreateEmployeeReport_Click);
            // 
            // btnCreateTaskReport
            // 
            this.btnCreateTaskReport.Location = new System.Drawing.Point(11, 79);
            this.btnCreateTaskReport.Name = "btnCreateTaskReport";
            this.btnCreateTaskReport.Size = new System.Drawing.Size(257, 53);
            this.btnCreateTaskReport.TabIndex = 2;
            this.btnCreateTaskReport.Text = "Створити звіт про завдання";
            this.btnCreateTaskReport.UseVisualStyleBackColor = true;
            this.btnCreateTaskReport.Click += new System.EventHandler(this.btnCreateTaskReport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(825, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(257, 53);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbCoverPage
            // 
            this.chbCoverPage.AutoSize = true;
            this.chbCoverPage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbCoverPage.Location = new System.Drawing.Point(18, 45);
            this.chbCoverPage.Name = "chbCoverPage";
            this.chbCoverPage.Size = new System.Drawing.Size(142, 36);
            this.chbCoverPage.TabIndex = 0;
            this.chbCoverPage.Text = "Титулка";
            this.chbCoverPage.UseVisualStyleBackColor = true;
            // 
            // chbIntroduction
            // 
            this.chbIntroduction.AutoSize = true;
            this.chbIntroduction.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbIntroduction.Location = new System.Drawing.Point(18, 97);
            this.chbIntroduction.Name = "chbIntroduction";
            this.chbIntroduction.Size = new System.Drawing.Size(112, 36);
            this.chbIntroduction.TabIndex = 1;
            this.chbIntroduction.Text = "Вступ";
            this.chbIntroduction.UseVisualStyleBackColor = true;
            // 
            // chbMainBody
            // 
            this.chbMainBody.AutoSize = true;
            this.chbMainBody.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbMainBody.Location = new System.Drawing.Point(18, 149);
            this.chbMainBody.Name = "chbMainBody";
            this.chbMainBody.Size = new System.Drawing.Size(253, 36);
            this.chbMainBody.TabIndex = 2;
            this.chbMainBody.Text = "Основна частина";
            this.chbMainBody.UseVisualStyleBackColor = true;
            // 
            // chbConclusions
            // 
            this.chbConclusions.AutoSize = true;
            this.chbConclusions.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbConclusions.Location = new System.Drawing.Point(18, 203);
            this.chbConclusions.Name = "chbConclusions";
            this.chbConclusions.Size = new System.Drawing.Size(160, 36);
            this.chbConclusions.TabIndex = 3;
            this.chbConclusions.Text = "Висновки";
            this.chbConclusions.UseVisualStyleBackColor = true;
            // 
            // chbReferences
            // 
            this.chbReferences.AutoSize = true;
            this.chbReferences.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbReferences.Location = new System.Drawing.Point(18, 259);
            this.chbReferences.Name = "chbReferences";
            this.chbReferences.Size = new System.Drawing.Size(170, 36);
            this.chbReferences.TabIndex = 4;
            this.chbReferences.Text = "Референси";
            this.chbReferences.UseVisualStyleBackColor = true;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Location = new System.Drawing.Point(18, 361);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(242, 53);
            this.btnCreateReport.TabIndex = 3;
            this.btnCreateReport.Text = "Створити звіт";
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1109, 635);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtxtReport);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Звіт";
            this.panel1.ResumeLayout(false);
            this.pCreationPanel.ResumeLayout(false);
            this.pCreationPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pCreationPanel;
        private System.Windows.Forms.RichTextBox rtxtReport;
        private System.Windows.Forms.Button btnCreateTaskReport;
        private System.Windows.Forms.Button btnCreateEmployeeReport;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.CheckBox chbReferences;
        private System.Windows.Forms.CheckBox chbConclusions;
        private System.Windows.Forms.CheckBox chbMainBody;
        private System.Windows.Forms.CheckBox chbIntroduction;
        private System.Windows.Forms.CheckBox chbCoverPage;
        private System.Windows.Forms.Button btnSave;
    }
}

