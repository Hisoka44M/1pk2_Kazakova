using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;


namespace Task_38_04
{
    public class Students
    {
        public ObservableCollection<Student> StudentsList { get; set; } = new();

        public void AddStudent(Student student)
        {
            StudentsList.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            StudentsList.Remove(student);
        }

        public void Load()
        {
            if (File.Exists("students.json"))
            {
                var json = File.ReadAllText("students.json");
                var data = JsonSerializer.Deserialize<ObservableCollection<Student>>(json);
                if (data != null)
                    StudentsList = data;
            }
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(StudentsList);
            File.WriteAllText("students.json", json);
        }
    }
}
