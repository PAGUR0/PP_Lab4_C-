using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class Reader
    {
        private string Surname;
        private string Name;
        private string Patronymic;
        public int Number;
        public string Faculty;
        private string Birthday;
        public string Phone;

        public Reader(string surname, string name, string patronymic, int number, string faculty, string birhday, string phone)
        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.Number = number;
            this.Faculty = faculty;
            this.Birthday = birhday;
            this.Phone = phone;
        }

        public void takeBook(int books)
        {
            Console.WriteLine($"{Surname}, {Name}, {Patronymic} взял {books} книги");
        }
        public void takeBook(params string[] books)
        {
            Console.WriteLine($"{Surname}, {Name}, {Patronymic} взял книги: {string.Join(", ", books)}");
        }

        public void returnBook(int books)
        {
            Console.WriteLine($"{Surname}, {Name}, {Patronymic} вернул {books} книги");
        }
        public void returnBook(params string[] books)
        {
            Console.WriteLine($"{Surname}, {Name}, {Patronymic} вернул книги: {string.Join(", ", books)}");
        }
    }
}
