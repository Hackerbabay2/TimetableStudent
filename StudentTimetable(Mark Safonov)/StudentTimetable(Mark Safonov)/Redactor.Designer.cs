
namespace StudentTimetable_Mark_Safonov_
{
    partial class Redactor
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
            this.label7 = new System.Windows.Forms.Label();
            this.endMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audienceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teacherBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DoneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameClassesBox = new System.Windows.Forms.TextBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Конец пары";
            // 
            // endMaskedBox
            // 
            this.endMaskedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.endMaskedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endMaskedBox.ForeColor = System.Drawing.Color.White;
            this.endMaskedBox.Location = new System.Drawing.Point(12, 99);
            this.endMaskedBox.Name = "endMaskedBox";
            this.endMaskedBox.Size = new System.Drawing.Size(121, 22);
            this.endMaskedBox.TabIndex = 27;
            this.endMaskedBox.ValidatingType = typeof(System.DateTime);
            this.endMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.endMaskedBox_TypeValidationCompleted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Аудитория";
            // 
            // audienceBox
            // 
            this.audienceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.audienceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.audienceBox.ForeColor = System.Drawing.Color.White;
            this.audienceBox.Location = new System.Drawing.Point(12, 155);
            this.audienceBox.Name = "audienceBox";
            this.audienceBox.Size = new System.Drawing.Size(122, 22);
            this.audienceBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Преподователь";
            // 
            // teacherBox
            // 
            this.teacherBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.teacherBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teacherBox.ForeColor = System.Drawing.Color.White;
            this.teacherBox.Location = new System.Drawing.Point(12, 127);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(122, 22);
            this.teacherBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Начало пары";
            // 
            // startMaskedBox
            // 
            this.startMaskedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.startMaskedBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startMaskedBox.ForeColor = System.Drawing.Color.White;
            this.startMaskedBox.Location = new System.Drawing.Point(12, 71);
            this.startMaskedBox.Name = "startMaskedBox";
            this.startMaskedBox.Size = new System.Drawing.Size(121, 22);
            this.startMaskedBox.TabIndex = 21;
            this.startMaskedBox.ValidatingType = typeof(System.DateTime);
            this.startMaskedBox.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.startMaskedBox_TypeValidationCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Вид занятия";
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DoneButton.ForeColor = System.Drawing.Color.White;
            this.DoneButton.Location = new System.Drawing.Point(13, 183);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(285, 38);
            this.DoneButton.TabIndex = 18;
            this.DoneButton.Text = "Применить";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название предмета";
            // 
            // NameClassesBox
            // 
            this.NameClassesBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.NameClassesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameClassesBox.ForeColor = System.Drawing.Color.White;
            this.NameClassesBox.Location = new System.Drawing.Point(12, 12);
            this.NameClassesBox.Name = "NameClassesBox";
            this.NameClassesBox.Size = new System.Drawing.Size(122, 22);
            this.NameClassesBox.TabIndex = 16;
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.typeBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeBox.ForeColor = System.Drawing.Color.White;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Урок",
            "Контрольная работа",
            "Практическая",
            "Лабараторная",
            "Теоретическое занятие",
            "Консультация",
            "Самостоятельная работа",
            "Учебная практика",
            "Курсовое проектирование"});
            this.typeBox.Location = new System.Drawing.Point(12, 40);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(121, 24);
            this.typeBox.TabIndex = 29;
            // 
            // Redactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(310, 244);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endMaskedBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.audienceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.teacherBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startMaskedBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameClassesBox);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Redactor";
            this.ShowIcon = false;
            this.Text = "Redactor";
            this.Load += new System.EventHandler(this.Redactor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox endMaskedBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox audienceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacherBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox startMaskedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameClassesBox;
        private System.Windows.Forms.ComboBox typeBox;
    }
}