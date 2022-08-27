using System;
using System.Collections.Generic;
namespace Exercises
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

    public class Exercise002
    {
        
        public bool IsFromManchester(Person P1)
        {
			if(P1 != null) 
				return P1.City == "Manchester"; 	
			else 
                return false;
        }

        public bool CanWatchFilm(Person P1, int ageLimit)
        {
            if(P1.Age < ageLimit)    
                return false;
            else
                return true;
        }
    }
}
