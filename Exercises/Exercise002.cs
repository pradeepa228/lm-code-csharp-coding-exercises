using System;
using System.Collections.Generic;
using Exercises.Models;
namespace Exercises
{
    public class Exercise002
    {
        
        public bool IsFromManchester(Person inputPerson)
        {
			if(inputPerson != null) {
				return inputPerson.City == "Manchester";
            }
            return false;
        }

        public bool CanWatchFilm(Person inputPerson, int ageLimit)
        {
            return (inputPerson.Age > ageLimit);
        }
    }
}
