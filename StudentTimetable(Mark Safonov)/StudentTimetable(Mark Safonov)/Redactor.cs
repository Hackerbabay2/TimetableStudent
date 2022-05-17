using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTimetable_Mark_Safonov_
{
    public partial class Redactor : Form
    {
        private Classes _classes;

        public Redactor(Classes classes)
        {
            InitializeComponent();
            _classes = classes;
            NameClassesBox.Text = _classes.Name;
            typeBox.Text = _classes.Type;
            startMaskedBox.Text = _classes.Start;
            endMaskedBox.Text = _classes.End;
            teacherBox.Text = _classes.Teacher;
            audienceBox.Text = _classes.Audience;

            startMaskedBox.Mask = "00:00";
            endMaskedBox.Mask = "00:00";

            startMaskedBox.ValidatingType = typeof(DateTime);
            startMaskedBox.TypeValidationCompleted += new TypeValidationEventHandler(startMaskedBox_TypeValidationCompleted);

            endMaskedBox.ValidatingType = typeof(DateTime);
            endMaskedBox.TypeValidationCompleted += new TypeValidationEventHandler(endMaskedBox_TypeValidationCompleted);
        }

        private void Redactor_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _classes.SetClasses(NameClassesBox.Text, startMaskedBox.Text, endMaskedBox.Text, typeBox.Text, teacherBox.Text, audienceBox.Text);

            DialogResult result = MessageBox.Show(
                "Завершить редактирование?",
                "Изменения применены",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly
                );

            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void startMaskedBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("не существует такого времени");
            }
        }

        private void endMaskedBox_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("не существует такого времени");
            }
        }
    }
}
