using System;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
         string alphapet = "abcdefghijklmnopqrstuvwxyz";
         int count = 0;
         string lowerStr = input.ToLower();

         foreach(char alphaChar in alphapet) {
             foreach(char inputChar in lowerStr) {
                 if(alphaChar == inputChar) {
                     count++;
                     break;
                 }
             }
         }
         return (count == 26);
        }
    }
}