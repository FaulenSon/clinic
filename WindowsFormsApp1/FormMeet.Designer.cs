﻿namespace WindowsFormsApp1
{
    partial class FormMeet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_NameTitle = new System.Windows.Forms.Label();
            this.comboBox_Doctors = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_5 = new System.Windows.Forms.FlowLayoutPanel();
            this.Lavel_for_date = new System.Windows.Forms.Label();
            this.comboBox_period = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите врача";
            // 
            // label_NameTitle
            // 
            this.label_NameTitle.AutoSize = true;
            this.label_NameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_NameTitle.Location = new System.Drawing.Point(10, 11);
            this.label_NameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NameTitle.Name = "label_NameTitle";
            this.label_NameTitle.Size = new System.Drawing.Size(251, 17);
            this.label_NameTitle.TabIndex = 1;
            this.label_NameTitle.Text = "Запись пациента: Имя Фамилия";
            // 
            // comboBox_Doctors
            // 
            this.comboBox_Doctors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Doctors.FormattingEnabled = true;
            this.comboBox_Doctors.Location = new System.Drawing.Point(124, 63);
            this.comboBox_Doctors.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Doctors.Name = "comboBox_Doctors";
            this.comboBox_Doctors.Size = new System.Drawing.Size(468, 21);
            this.comboBox_Doctors.TabIndex = 20;
            this.comboBox_Doctors.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Doctors_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(10, 95);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(581, 333);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel_1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(573, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ПН";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_1
            // 
            this.flowLayoutPanel_1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_1.Location = new System.Drawing.Point(5, 6);
            this.flowLayoutPanel_1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_1.Name = "flowLayoutPanel_1";
            this.flowLayoutPanel_1.Size = new System.Drawing.Size(566, 327);
            this.flowLayoutPanel_1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.flowLayoutPanel_2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(573, 307);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ВТ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_2
            // 
            this.flowLayoutPanel_2.Location = new System.Drawing.Point(4, 6);
            this.flowLayoutPanel_2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_2.Name = "flowLayoutPanel_2";
            this.flowLayoutPanel_2.Size = new System.Drawing.Size(566, 327);
            this.flowLayoutPanel_2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel_3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(573, 307);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "СР";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_3
            // 
            this.flowLayoutPanel_3.Location = new System.Drawing.Point(4, 6);
            this.flowLayoutPanel_3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_3.Name = "flowLayoutPanel_3";
            this.flowLayoutPanel_3.Size = new System.Drawing.Size(566, 327);
            this.flowLayoutPanel_3.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.flowLayoutPanel_4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(573, 307);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "ЧТ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_4
            // 
            this.flowLayoutPanel_4.Location = new System.Drawing.Point(4, 6);
            this.flowLayoutPanel_4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_4.Name = "flowLayoutPanel_4";
            this.flowLayoutPanel_4.Size = new System.Drawing.Size(566, 327);
            this.flowLayoutPanel_4.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.flowLayoutPanel_5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(573, 307);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "ПТ";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_5
            // 
            this.flowLayoutPanel_5.Location = new System.Drawing.Point(4, 6);
            this.flowLayoutPanel_5.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_5.Name = "flowLayoutPanel_5";
            this.flowLayoutPanel_5.Size = new System.Drawing.Size(566, 327);
            this.flowLayoutPanel_5.TabIndex = 2;
            this.flowLayoutPanel_5.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_5_Paint);
            // 
            // Lavel_for_date
            // 
            this.Lavel_for_date.AutoSize = true;
            this.Lavel_for_date.Location = new System.Drawing.Point(10, 37);
            this.Lavel_for_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lavel_for_date.Name = "Lavel_for_date";
            this.Lavel_for_date.Size = new System.Drawing.Size(96, 13);
            this.Lavel_for_date.TabIndex = 22;
            this.Lavel_for_date.Text = "Выберите период";
            // 
            // comboBox_period
            // 
            this.comboBox_period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_period.FormattingEnabled = true;
            this.comboBox_period.Location = new System.Drawing.Point(124, 37);
            this.comboBox_period.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_period.Name = "comboBox_period";
            this.comboBox_period.Size = new System.Drawing.Size(468, 21);
            this.comboBox_period.TabIndex = 23;
            this.comboBox_period.SelectedIndexChanged += new System.EventHandler(this.comboBox_period_SelectedIndexChanged);
            // 
            // FormMeet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 438);
            this.Controls.Add(this.comboBox_period);
            this.Controls.Add(this.Lavel_for_date);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox_Doctors);
            this.Controls.Add(this.label_NameTitle);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMeet";
            this.Text = "Запись на прием";
            this.Load += new System.EventHandler(this.FormMeet_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NameTitle;
        private System.Windows.Forms.ComboBox comboBox_Doctors;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_5;
        private System.Windows.Forms.Label Lavel_for_date;
        private System.Windows.Forms.ComboBox comboBox_period;
    }
}