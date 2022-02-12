using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 };
            IEnumerable<int> evens = numbers.Where(i => i % 2 == 0 && i > 10);
            List<User> users = new List<User>()
{
    new User { Name = "Sam", Age = 43 },
    new User { Name = "Tom", Age = 33 }
};
            List<Phone> phones = new List<Phone>()
{
    new Phone {Name="Lumia 630", Company="Microsoft" },
    new Phone {Name="iPhone 6", Company="Apple"},
};

            var people = from user in users
                         from phone in phones
                         select new { Name = user.Name, Phone = phone.Name };

            foreach (var p in people)
                Console.WriteLine($"{p.Name} - {p.Phone}");

            Console.ReadLine();
        }
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        class Phone
        {
            public string Name { get; set; }
            public string Company { get; set; }
        }
        
    }
}
