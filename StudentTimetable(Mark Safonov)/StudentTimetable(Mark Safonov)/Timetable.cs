using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentTimetable_Mark_Safonov_
{
    [Serializable]
    public class Timetable
    {
        public Timetable() { }

        public List<DayWeek> DayWeeks { get; set; } = new List<DayWeek>();

        public Timetable(int count)
        {
            for (int i = 0; i < count; i++)
            {
                DayWeeks.Add(new DayWeek());
            }
        }

        public void AddClasses(int index, string name, string start,string end, string type, string teacher, string audience)
        {
            int id = DayWeeks[index].CountClasses + 1;
            DayWeeks[index].ClassesList.Add(new Classes(id,name,start,end,type,teacher,audience));
        }

        public Classes GetClassesById(int indexSelected,int id)
        {
            foreach (Classes classes in DayWeeks[indexSelected].ClassesList)
            {
                if (classes.Id == id)
                {
                    return classes;
                }
            }

            return null;
        }

        public void RemoveClassesById(int index, int id)
        {
            foreach (Classes classes in DayWeeks[index].ClassesList)
            {
                if (classes.Id == id)
                {
                    DayWeeks[index].ClassesList.Remove(classes);
                    return;
                }
            }

            MessageBox.Show("Пара не найдена");
        }

        public void ShowData(ListView listView, ListViewGroupCollection listViewGroupCollection)
        {
            ListViewItem items = null;

            for (int i = 0; i < DayWeeks.Count; i++)
            {
                foreach (Classes classes in DayWeeks[i].ClassesList)
                {
                    items = new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience
                    },"",listViewGroupCollection[i]);

                    listView.Items.Add(items);
                }
            }
        }

        public void ShowDataByAttribute(string attribute, string path, ListViewGroupCollection listViewGroupCollection, ListView listView)
        {
            List<ListViewItem> items = GetDataByAttribute(attribute,path,listViewGroupCollection);

            if (items.Count > 0)
            {
                listView.Items.Clear();

                foreach (ListViewItem item in items)
                {
                    listView.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено");
            }
        }

        public List<ListViewItem> GetDataByAttribute(string attribute, string path, ListViewGroupCollection listViewGroupCollection)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            string data = null;

            for (int i = 0; i < DayWeeks.Count; i++)
            {
                foreach (Classes classes in DayWeeks[i].ClassesList)
                {
                    if (classes.Id.ToString() == attribute)
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }
                    else if (classes.Name.ToLower().Contains(attribute.ToLower()))
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }
                    else if ((classes.Start + " - " + classes.End).ToLower().Contains(attribute.ToLower()))
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }
                    else if (classes.Audience.ToLower().Contains(attribute.ToLower()))
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }
                    else if (classes.Teacher.ToLower().Contains(attribute.ToLower()))
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }
                    else if (classes.Type.ToLower().Contains(attribute.ToLower()))
                    {
                        items.Add(new ListViewItem(new string[] {
                        classes.Id.ToString(),
                        classes.Name,
                        classes.Type,
                        classes.Start + " - " + classes.End,
                        classes.Teacher,
                        classes.Audience },
                        "", listViewGroupCollection[i]));
                        data += GetDataClasses(classes);
                    }

                }

                if (data != null)
                {
                    data += "\n";
                }
            }

            if (data != null)
                File.WriteAllText(path,data);

            return items;
        }

        public string GetDataClasses(Classes classes)
        {
            string data = $"{classes.Id} " +
                $"{classes.Name} " +
                $"{classes.Start} - {classes.End} " +
                $"{classes.Teacher} " +
                $"{classes.Audience}\n";
            return data;
        }
    }

    [Serializable]
    public class DayWeek
    {
        public List<Classes> ClassesList { get; set; } = new List<Classes>();
        public int CountClasses => ClassesList.Count;

        public DayWeek() { }
    }

    [Serializable]
    public class Classes
    {
        [XmlElement("Classes")]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public string Type { get; set; }
        public string Teacher { get; set; }
        public string Audience { get; set; }

        public Classes() { }

        public Classes(int id, string name, string start,string end, string type, string teacher, string audience)
        {
            Id = id;
            Name = name;
            Start = start;
            End = end;
            Type = type;
            Teacher = teacher;
            Audience = audience;
        }

        public void SetClasses(string name, string start, string end, string type, string teacher, string audience)
        {
            Name = name;
            Start = start;
            End = end;
            Type = type;
            Teacher = teacher;
            Audience = audience;
        }
    }
}
