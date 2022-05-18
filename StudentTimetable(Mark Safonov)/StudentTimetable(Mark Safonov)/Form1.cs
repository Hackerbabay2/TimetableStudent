using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentTimetable_Mark_Safonov_
{
    public partial class Form1 : Form
    {
        private ListViewGroupCollection _listViewGroupCollections;  
        private Timetable _timetable;
        private string _pathFound = "foundData.txt";

        public Form1()
        {
            InitializeComponent();
            _listViewGroupCollections = timetableView.Groups;
            _timetable = new Timetable(6);
            dayWeeksComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            startMaskedBox.Mask = "00:00";
            endMaskedBox.Mask = "00:00";

            startMaskedBox.ValidatingType = typeof(DateTime);
            startMaskedBox.TypeValidationCompleted += new TypeValidationEventHandler(startMaskedBox_TypeValidationCompleted);

            endMaskedBox.ValidatingType = typeof(DateTime);
            endMaskedBox.TypeValidationCompleted += new TypeValidationEventHandler(endMaskedBox_TypeValidationCompleted);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dayWeeksComboBox.SelectedIndex >= 0)
            {
                timetableView.Items.Clear();
                _timetable.AddClasses(dayWeeksComboBox.SelectedIndex,NameClassesBox.Text,startMaskedBox.Text,endMaskedBox.Text,typeBox.Text,teacherBox.Text,audienceBox.Text);
                _timetable.ShowData(timetableView,_listViewGroupCollections);
            }
            else
            {
                MessageBox.Show("Выберете день недели");
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

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListView listview = (ListView)sender;

            if (e.Column == ListViewItemComparer.SortColumn)
            {
                if (ListViewItemComparer.Order == SortOrder.Ascending)
                {
                    ListViewItemComparer.Order = SortOrder.Descending;
                }
                else
                {
                    ListViewItemComparer.Order = SortOrder.Ascending;
                }
            }
            else
            {
                ListViewItemComparer.SortColumn = e.Column;
                ListViewItemComparer.Order = SortOrder.Ascending;
            }
            this.timetableView.ListViewItemSorter = new ListViewItemComparer(e.Column);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _timetable.ShowDataByAttribute(searchBox.Text,_pathFound,_listViewGroupCollections,timetableView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dayWeeksComboBox.SelectedIndex >= 0)
            {
                if (_timetable.GetClassesById(dayWeeksComboBox.SelectedIndex, (int)idNumeric.Value) != null)
                {
                    Redactor redactor = new Redactor(_timetable.GetClassesById(dayWeeksComboBox.SelectedIndex, (int)idNumeric.Value));
                    redactor.Show();
                }
                else
                {
                    MessageBox.Show("Номер пары не найден");
                }
            }
            else
            {
                MessageBox.Show("Выберете день недели");
            }
        }

        private void SerializeXML(Timetable timetable, string pathFile)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Timetable));

            using (FileStream fileStream = new FileStream(pathFile, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fileStream, timetable);
            }
        }

        private Timetable DeseriacliezeXml(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Timetable));

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (Timetable)xmlSerializer.Deserialize(fileStream);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            openFileDialog.ShowDialog();

            try
            {
                if (openFileDialog.FileName.EndsWith(".xml"))
                {
                    _timetable = DeseriacliezeXml(openFileDialog.FileName);
                    _timetable.ShowData(timetableView,_listViewGroupCollections);
                }
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = ".xml (*.xml*)|*.xml*";
            saveFileDialog.ShowDialog();

            if (!saveFileDialog.FileName.EndsWith(".xml"))
                saveFileDialog.FileName += ".xml";

            File.Delete(saveFileDialog.FileName);
            SerializeXML(_timetable, saveFileDialog.FileName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timetableView.Items.Clear();   
            _timetable.ShowData(timetableView,_listViewGroupCollections);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _timetable.RemoveClassesById(dayWeeksComboBox.SelectedIndex,(int)idNumeric.Value);
            timetableView.Items.Clear();
            _timetable.ShowData(timetableView,_listViewGroupCollections);
        }
    }
}
