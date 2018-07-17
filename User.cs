using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get; set; }

        public User(string Name, string Surname, DateTime Birthday)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Birthday = Birthday;
            Age = DateTime.Now.Year - Birthday.Year;

        }
    }
}
