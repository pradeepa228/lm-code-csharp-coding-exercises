using System;
namespace Exercises.Models
{
    public class Person
    {
		public string FirstName;
		public string LastName;
		public string City;
        public int Age;

		public Person(string firstname, string lastname, string city, int age)
		{
		    FirstName = firstname;
		    LastName = lastname;
		    City = city;
            Age = age;
		}
	}
}