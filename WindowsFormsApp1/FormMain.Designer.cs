namespace WindowsFormsApp1
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox_SearchDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Doctors = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox_SearchPat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel_Patients = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_Visits = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(4, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить врача";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Телефон: +375 (25) 935-05-81";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.Location = new System.Drawing.Point(10, 11);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(416, 17);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Программная система для регистратуры поликлиники";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(462, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(188, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(96, 22);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 56);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить пациента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(636, 432);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_SearchDoc);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.flowLayoutPanel_Doctors);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(628, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список врачей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox_SearchDoc
            // 
            this.textBox_SearchDoc.Location = new System.Drawing.Point(146, 8);
            this.textBox_SearchDoc.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SearchDoc.Name = "textBox_SearchDoc";
            this.textBox_SearchDoc.Size = new System.Drawing.Size(478, 20);
            this.textBox_SearchDoc.TabIndex = 2;
            this.textBox_SearchDoc.TextChanged += new System.EventHandler(this.textBox_SearchDoc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Поиск по фамилии врача:";
            // 
            // flowLayoutPanel_Doctors
            // 
            this.flowLayoutPanel_Doctors.AutoScroll = true;
            this.flowLayoutPanel_Doctors.Location = new System.Drawing.Point(4, 31);
            this.flowLayoutPanel_Doctors.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_Doctors.Name = "flowLayoutPanel_Doctors";
            this.flowLayoutPanel_Doctors.Size = new System.Drawing.Size(621, 371);
            this.flowLayoutPanel_Doctors.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox_SearchPat);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.flowLayoutPanel_Patients);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(628, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список пациентов";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox_SearchPat
            // 
            this.textBox_SearchPat.Location = new System.Drawing.Point(164, 9);
            this.textBox_SearchPat.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SearchPat.Name = "textBox_SearchPat";
            this.textBox_SearchPat.Size = new System.Drawing.Size(460, 20);
            this.textBox_SearchPat.TabIndex = 4;
            this.textBox_SearchPat.TextChanged += new System.EventHandler(this.textBox_SearchPat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Поиск по фамилии пациента:";
            // 
            // flowLayoutPanel_Patients
            // 
            this.flowLayoutPanel_Patients.AutoScroll = true;
            this.flowLayoutPanel_Patients.Location = new System.Drawing.Point(4, 33);
            this.flowLayoutPanel_Patients.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_Patients.Name = "flowLayoutPanel_Patients";
            this.flowLayoutPanel_Patients.Size = new System.Drawing.Size(621, 369);
            this.flowLayoutPanel_Patients.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.flowLayoutPanel_Visits);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(628, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Список записей";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Visits
            // 
            this.flowLayoutPanel_Visits.AutoScroll = true;
            this.flowLayoutPanel_Visits.Location = new System.Drawing.Point(4, 2);
            this.flowLayoutPanel_Visits.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel_Visits.Name = "flowLayoutPanel_Visits";
            this.flowLayoutPanel_Visits.Size = new System.Drawing.Size(621, 402);
            this.flowLayoutPanel_Visits.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(534, 525);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Автор: Паньков С.М.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(153, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(659, 547);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Программная система для регистратуры поликлиники";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Doctors;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Patients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SearchDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SearchPat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Visits;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

