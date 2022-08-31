using System;
using System.Collections.Generic;
using Exercises.Models;
namespace Exercises
{
    public class Exercise002
    {
        
        public bool IsFromManchester(Person inputPerson)
        {
            return inputPerson != null && inputPerson.City == "Manchester";
        }

        public bool CanWatchFilm(Person inputPerson, int ageLimit)
        {
            return (inputPerson.Age > ageLimit);
        }
    }
}
