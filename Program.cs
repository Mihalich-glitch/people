using System;
using System.Collections.Generic;
using System.Linq;

namespace people
{
    class Human {

        string[] names = new string[] {"Egor", "Roman", "Vladimir", "Alexander", "Ivan", "Artyom", "Yaroslav", "Mikhail", "Arthur", "Nekita"};
        string[] secondNames = new string[] {"Vorobiev", "Strigin", "Bairamov", "Ivanov", "Petrov", "Sokolov", "Smirnov", "Popov", "Morozov", "Volkov"};       
        int[] dates = new int[] {200304, 210505, 040595, 050606, 070809, 010203, 170209, 060990, 150809, 120584};
        string _name;
        string _secondName;
        int _date;

        Random r = new Random();

        public Human()
        {
            _name = names[r.Next(0, names.Length)];
            _secondName = secondNames[r.Next(0, secondNames.Length)];
            _date = dates[r.Next(0, dates.Length)];
        }

        public string GetName()
        {
            return _name;
        }

        public string GetSecondName()
        {
            return _secondName;
        }

        public int GetDate()
        {
            return _date;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();
            Human h2 = new Human();
            Human h3 = new Human();
            Human h4 = new Human();
            Human h5 = new Human();
            Human h6 = new Human();
            Human h7 = new Human();
            Human h8 = new Human();
            Human h9 = new Human();
            Human h10 = new Human();


            Dictionary<Human, int> people = new Dictionary <Human, int>
            {
                {h1, 1},
                {h2, 2},
                {h3, 3},
                {h4, 4},
                {h5, 5},
                {h6, 6},
                {h7, 7},
                {h8, 8},
                {h9, 9},
                {h10, 10}
            };

            Console.Write("Введите число от 1 до 10: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            foreach (var key in people.Keys)
            {
                if (people[key] == a)
                {
                    Console.WriteLine($"имя: {key.GetName()}, фамилия: {key.GetSecondName()}, дата рождения: {key.GetDate()}");
                }
            }
        }
    }

}