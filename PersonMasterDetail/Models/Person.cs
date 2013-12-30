using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonMasterDetail.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public static class PersonDB
    {
        private static Random _rnd = new Random();
        private static string[] _firstNames = { "Alex", "John", "Mike", "Joe", "Phil", "Paul", "Frank", "David" };
        private static string[] _lastNames = { "Friedman", "Jones", "Johnson", "Davidson", "Jordan", "Cobain", "Wlaters" };
        private static List<Person> _people;
        public static IEnumerable<Person> GetPeople()
        {
            if (_people == null)
            {
                var list = new List<Person>();
                for (int i = 1; i <= 10; i++)
                {
                    list.Add(new Person
                        {
                            Id = i,
                            FirstName = _firstNames[_rnd.Next(_firstNames.Length)],
                            LastName = _lastNames[_rnd.Next(_lastNames.Length)],
                            Age = _rnd.Next(20, 100)
                        });
                }
                _people = list;
            }
            return _people;
        }
    }

    public class AllPersonsViewModel
    {
        public IEnumerable<Person> People { get; set; }
    }

    public class PersonViewModel
    {
        public Person Person { get; set; }
    }
}