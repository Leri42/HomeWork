using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Parent
    {
        public int Calculatur()
        {
            Console.WriteLine("Please Enter fist Number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            return firstNum * secondNumber;
        }
    }
}
