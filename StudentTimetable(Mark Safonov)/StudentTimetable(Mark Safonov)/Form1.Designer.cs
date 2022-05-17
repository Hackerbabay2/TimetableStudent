
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
            System.Windows.Forms.ListViewGroup listViewGroup13 = new System.Windows.Forms.ListViewGroup("Понедельник", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup14 = new System.Windows.Forms.ListViewGroup("Вторник", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup15 = new System.Windows.Forms.ListViewGroup("Среда", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup16 = new System.Windows.Forms.ListViewGroup("Четверг", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup17 = new System.Windows.Forms.ListViewGroup("Пятница", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup18 = new System.Windows.Forms.ListViewGroup("Суббота", System.Windows.Forms.HorizontalAlignment.Left);
            this.timetableView = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.durationClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.audience = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NameClassesBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.timetableView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.subject,
            this.type,
            this.durationClasses,
            this.teacher,
            this.audience});
            this.timetableView.GridLines = true;
            listViewGroup13.Header = "Понедельник";
            listViewGroup13.Name = "Moneday";
            listViewGroup14.Header = "Вторник";
            listViewGroup14.Name = "listViewGroup2";
            listViewGroup15.Header = "Среда";
            listViewGroup15.Name = "listViewGroup3";
            listViewGroup16.Header = "Четверг";
            listViewGroup16.Name = "listViewGroup4";
            listViewGroup17.Header = "Пятница";
            listViewGroup17.Name = "listViewGroup5";
            listViewGroup18.Header = "Суббота";
            listViewGroup18.Name = "listViewGroup6";
            this.timetableView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup13,
            listViewGroup14,
            listViewGroup15,
            listViewGroup16,
            listViewGroup17,
            listViewGroup18});
            this.timetableView.HideSelection = false;
            this.timetableView.Location = new System.Drawing.Point(12, 12);
            this.timetableView.Name = "listView1";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота"});
            this.comboBox1.Location = new System.Drawing.Point(666, 140);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // NameClassesBox
            // 
            this.NameClassesBox.Location = new System.Drawing.Point(666, 170);
            this.NameClassesBox.Name = "NameClassesBox";
            this.NameClassesBox.Size = new System.Drawing.Size(123, 22);
            this.NameClassesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(793, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название предмета";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(666, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вид занятия";
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(666, 200);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(123, 22);
            this.typeBox.TabIndex = 5;
            // 
            // startMaskedBox
            // 
            this.startMaskedBox.Location = new System.Drawing.Point(666, 229);
            this.startMaskedBox.Name = "startMaskedBox";
            this.startMaskedBox.Size = new System.Drawing.Size(123, 22);
            this.startMaskedBox.TabIndex = 7;
            this.startMaskedBox.ValidatingType = typeof(System.DateTime);
            this.startMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.startMaskedBox_TypeValidationCompleted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(794, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Начало пары";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Преподователь";
            // 
            // teacherBox
            // 
            this.teacherBox.Location = new System.Drawing.Point(666, 285);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(123, 22);
            this.teacherBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(794, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Аудитория";
            // 
            // audienceBox
            // 
            this.audienceBox.Location = new System.Drawing.Point(666, 313);
            this.audienceBox.Name = "audienceBox";
            this.audienceBox.Size = new System.Drawing.Size(123, 22);
            this.audienceBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "День недели";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(794, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Конец пары";
            // 
            // endMaskedBox
            // 
            this.endMaskedBox.Location = new System.Drawing.Point(666, 257);
            this.endMaskedBox.Name = "endMaskedBox";
            this.endMaskedBox.Size = new System.Drawing.Size(123, 22);
            this.endMaskedBox.TabIndex = 14;
            this.endMaskedBox.ValidatingType = typeof(System.DateTime);
            this.endMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.endMaskedBox_TypeValidationCompleted);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(667, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(122, 22);
            this.searchBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(795, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 22);
            this.button2.TabIndex = 17;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(667, 112);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(766, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "№";
            // 
            // button3
            // 
            this.button3.AccessibleDescription = "";
            this.button3.Location = new System.Drawing.Point(793, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 22);
            this.button3.TabIndex = 20;
            this.button3.Text = "Редактировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(666, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 38);
            this.button4.TabIndex = 21;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(666, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 38);
            this.button5.TabIndex = 22;
            this.button5.Text = "Загрузить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(667, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Обновить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 485);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameClassesBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.timetableView);
            this.Name = "Form1";
            this.Text = "Расписание студента";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

