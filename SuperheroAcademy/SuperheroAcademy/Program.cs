using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroAcademy
{
    class Program
    {
        static void Main(string[] args)
        {

            Human currentStudent;
            Console.WriteLine("Please input the name of the applicant student.");
            string tempName = Console.ReadLine();
            
            Console.WriteLine("Please input the corresponding numbe of the type of power of the applicant student");
            Console.WriteLine("\"1\" Enhancement");
            Console.WriteLine("\"2\" Manipulation");
            Console.WriteLine("\"3\" Conjuration");
            bool passed = false;
            int tempType = 0;

            while (!passed){

                passed = int.TryParse(Console.ReadLine(), out tempType);
                    }
            if(tempType == 1)
            {
                currentStudent = new Enhancement();
                
            }
            else if (tempType == 2)
            {
                currentStudent = new Manipulation();
                
            }
            else if (tempType == 3)
            {
                currentStudent = new Conjuration();
                 
            }
            else
            {
                currentStudent = new Human();
            }
            Console.WriteLine("Wellcome " + currentStudent.name);
            
        }

    }
}
