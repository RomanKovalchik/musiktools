using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    internal class Product: Money
    {
        
        private double discount;
       
       public Product(int holePart, int decimaPart, string currency, 
           double discount) : base(holePart, decimaPart, currency)
        {

           
            this.discount = discount;
            

        }

        public double getDiscount() { 
            double originSum = holePart + 0.01*decimaPart;
            double discSum = (originSum * discount)/100;

            return originSum - discSum;
        }

       
        public override string ToString()
        {
            return $"The original total price is: " + holePart + "," + decimaPart + " " + currency+ "\n" +
                "The price with discount " + discount + " is " + this.getDiscount() + " " + currency;
        }

    }
}
