
namespace StudentTimetable_Mark_Safonov_
{
    partial class Form1
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Понедельник", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Вторник", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Среда", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Четверг", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Пятница", System.Windows.Forms.HorizontalAlignment.Center);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Суббота", System.Windows.Forms.HorizontalAlignment.Center);
            this.timetableView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.audience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dayWeeksComboBox = new System.Windows.Forms.ComboBox();
            this.NameClassesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.startMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audienceBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.endMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.SerachButton = new System.Windows.Forms.Button();
            this.idNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.RedactorButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // timetableView
            // 
            this.timetableView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.timetableView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timetableView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.subject,
            this.type,
            this.durationClasses,
            this.teacher,
            this.audience});
            this.timetableView.ForeColor = System.Drawing.Color.White;
            this.timetableView.GridLines = true;
            listViewGroup1.Header = "Понедельник";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "Moneday";
            listViewGroup2.Header = "Вторник";
            listViewGroup2.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "Среда";
            listViewGroup3.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "Четверг";
            listViewGroup4.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup4.Name = "listViewGroup4";
            listViewGroup5.Header = "Пятница";
            listViewGroup5.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup5.Name = "listViewGroup5";
            listViewGroup6.Header = "Суббота";
            listViewGroup6.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup6.Name = "listViewGroup6";
            this.timetableView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.timetableView.HideSelection = false;
            this.timetableView.Location = new System.Drawing.Point(12, 12);
            this.timetableView.Name = "timetableView";
            this.timetableView.Size = new System.Drawing.Size(648, 461);
            this.timetableView.TabIndex = 0;
            this.timetableView.UseCompatibleStateImageBehavior = false;
            this.timetableView.View = System.Windows.Forms.View.Details;
            this.timetableView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // Id
            // 
            this.Id.Text = "№";
            this.Id.Width = 38;
            // 
            // subject
            // 
            this.subject.Text = "Название предмета";
            this.subject.Width = 158;
            // 
            // type
            // 
            this.type.Text = "Вид занятия";
            this.type.Width = 107;
            // 
            // durationClasses
            // 
            this.durationClasses.Text = "Продолжительность занятия";
            this.durationClasses.Width = 210;
            // 
            // teacher
            // 
            this.teacher.Text = "Преподователь";
            this.teacher.Width = 130;
            // 
            // audience
            // 
            this.audience.Text = "Аудитория";
            this.audience.Width = 89;
            // 
            // dayWeeksComboBox
            // 
            this.dayWeeksComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.dayWeeksComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dayWeeksComboBox.ForeColor = System.Drawing.Color.White;
            this.dayWeeksComboBox.FormattingEnabled = true;
            this.dayWeeksComboBox.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.dayWeeksComboBox.Location = new System.Drawing.Point(666, 140);
            this.dayWeeksComboBox.Name = "dayWeeksComboBox";
            this.dayWeeksComboBox.Size = new System.Drawing.Size(123, 24);
            this.dayWeeksComboBox.TabIndex = 1;
            // 
            // NameClassesBox
            // 
            this.NameClassesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.NameClassesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameClassesBox.ForeColor = System.Drawing.Color.White;
            this.NameClassesBox.Location = new System.Drawing.Point(666, 170);
            this.NameClassesBox.MaxLength = 100;
            this.NameClassesBox.Name = "NameClassesBox";
            this.NameClassesBox.Size = new System.Drawing.Size(123, 22);
            this.NameClassesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(793, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предмета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(666, 341);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 38);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(794, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид занятия";
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.typeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeBox.ForeColor = System.Drawing.Color.White;
            this.typeBox.Location = new System.Drawing.Point(666, 198);
            this.typeBox.MaxLength = 100;
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(123, 22);
            this.typeBox.TabIndex = 5;
            // 
            // startMaskedBox
            // 
            this.startMaskedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.startMaskedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMaskedBox.ForeColor = System.Drawing.Color.White;
            this.startMaskedBox.Location = new System.Drawing.Point(666, 226);
            this.startMaskedBox.Name = "startMaskedBox";
            this.startMaskedBox.Size = new System.Drawing.Size(123, 22);
            this.startMaskedBox.TabIndex = 7;
            this.startMaskedBox.ValidatingType = typeof(System.DateTime);
            this.startMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.startMaskedBox_TypeValidationCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(794, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начало пары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(794, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Преподователь";
            // 
            // teacherBox
            // 
            this.teacherBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.teacherBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherBox.ForeColor = System.Drawing.Color.White;
            this.teacherBox.Location = new System.Drawing.Point(666, 282);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(123, 22);
            this.teacherBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(794, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Аудитория";
            // 
            // audienceBox
            // 
            this.audienceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.audienceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audienceBox.ForeColor = System.Drawing.Color.White;
            this.audienceBox.Location = new System.Drawing.Point(666, 310);
            this.audienceBox.Name = "audienceBox";
            this.audienceBox.Size = new System.Drawing.Size(123, 22);
            this.audienceBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(794, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "День недели";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(794, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Конец пары";
            // 
            // endMaskedBox
            // 
            this.endMaskedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.endMaskedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endMaskedBox.ForeColor = System.Drawing.Color.White;
            this.endMaskedBox.Location = new System.Drawing.Point(666, 254);
            this.endMaskedBox.Name = "endMaskedBox";
            this.endMaskedBox.Size = new System.Drawing.Size(123, 22);
            this.endMaskedBox.TabIndex = 14;
            this.endMaskedBox.ValidatingType = typeof(System.DateTime);
            this.endMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.endMaskedBox_TypeValidationCompleted);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.Location = new System.Drawing.Point(667, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(122, 22);
            this.searchBox.TabIndex = 16;
            // 
            // SerachButton
            // 
            this.SerachButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.SerachButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SerachButton.ForeColor = System.Drawing.Color.White;
            this.SerachButton.Location = new System.Drawing.Point(795, 12);
            this.SerachButton.Name = "SerachButton";
            this.SerachButton.Size = new System.Drawing.Size(121, 29);
            this.SerachButton.TabIndex = 17;
            this.SerachButton.Text = "Поиск";
            this.SerachButton.UseVisualStyleBackColor = false;
            this.SerachButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // idNumeric
            // 
            this.idNumeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.idNumeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idNumeric.ForeColor = System.Drawing.Color.White;
            this.idNumeric.Location = new System.Drawing.Point(667, 112);
            this.idNumeric.Name = "idNumeric";
            this.idNumeric.Size = new System.Drawing.Size(93, 22);
            this.idNumeric.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(766, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "№";
            // 
            // RedactorButton
            // 
            this.RedactorButton.AccessibleDescription = "";
            this.RedactorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.RedactorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RedactorButton.ForeColor = System.Drawing.Color.White;
            this.RedactorButton.Location = new System.Drawing.Point(795, 71);
            this.RedactorButton.Name = "RedactorButton";
            this.RedactorButton.Size = new System.Drawing.Size(121, 27);
            this.RedactorButton.TabIndex = 20;
            this.RedactorButton.Text = "Редактировать";
            this.RedactorButton.UseVisualStyleBackColor = false;
            this.RedactorButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(667, 385);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(123, 38);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoadButton.ForeColor = System.Drawing.Color.White;
            this.LoadButton.Location = new System.Drawing.Point(666, 429);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(123, 38);
            this.LoadButton.TabIndex = 22;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReloadButton.ForeColor = System.Drawing.Color.White;
            this.ReloadButton.Location = new System.Drawing.Point(667, 41);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(122, 26);
            this.ReloadButton.TabIndex = 23;
            this.ReloadButton.Text = "Обновить";
            this.ReloadButton.UseVisualStyleBackColor = false;
            this.ReloadButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.AccessibleDescription = "";
            this.RemoveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(795, 107);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 27);
            this.RemoveButton.TabIndex = 24;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(952, 485);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.RedactorButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idNumeric);
            this.Controls.Add(this.SerachButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endMaskedBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.audienceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startMaskedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameClassesBox);
            this.Controls.Add(this.dayWeeksComboBox);
            this.Controls.Add(this.timetableView);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Расписание студента";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.idNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView timetableView;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader subject;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader durationClasses;
        private System.Windows.Forms.ColumnHeader teacher;
        private System.Windows.Forms.TextBox NameClassesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox dayWeeksComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.MaskedTextBox startMaskedBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox audienceBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader audience;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox endMaskedBox;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button SerachButton;
        private System.Windows.Forms.NumericUpDown idNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RedactorButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button RemoveButton;
    }
}

