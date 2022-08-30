using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours = {  "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet"};

        public int IceCreamCode(string inputIceCreamFlavour)
       {
           int iceCreamCode = 0;
          
           foreach (string eachFlavour in IceCreamFlavours) {
                if (eachFlavour == inputIceCreamFlavour) {
                  break;
                }
                else {
                   iceCreamCode++;
                }
           } 
           return iceCreamCode;
        }
    }
}
