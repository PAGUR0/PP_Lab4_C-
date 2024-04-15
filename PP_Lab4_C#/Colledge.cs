using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colledge
{
    struct Student
    {
        public string Surname;
        public string Name;
        public string Patronymic;
        public string GroupNumber;
        private int Age;

        public Student(string surname, string name, string patronymic, string groupNumber, int age)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.GroupNumber = groupNumber;
            this.Age = age;
        }

        public void infoStudent()
        {
            Console.WriteLine($"{Surname}, {Name}, {Patronymic}, {GroupNumber},{Age}");
        }
    }
}
