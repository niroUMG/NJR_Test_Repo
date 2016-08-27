using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_One.Rectangle
{
    class ExecutableRectangle
    {
        public static void Main(string[] args)
        {
            Rectangle rectangleOne = new Rectangle();
            rectangleOne.Acceptdetails();
            rectangleOne.display();
            Console.WriteLine("Please Type Anything and Press Return to Quit");
            Console.ReadLine();


        }
    }
}
