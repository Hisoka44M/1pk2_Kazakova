using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{

    public enum StudentFlour
    {
        Мужской,
        Женский
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public DateTime Birthday { get; set; }
        public StudentFlour Flour { get; set; }

        public Student(string name, string surname, string patronymic, string group, DateTime birthday, StudentFlour flour)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Group = group;
            Birthday = birthday;
            Flour = flour;
        }

        public string FlourOfStudent() => Flour.ToString();

        public override string ToString() => $"{Surname} {Name} {Patronymic}";
    }
}
