using System;

namespace Loops___Percent_Passing
{
    class Program
    {
        static void Main(string[] args)
        {
            int above;
            int done;
          
            int user;
            int total;
            double result;

            done = 000;
            above = 0;
            total = 0;

            Console.WriteLine("Hello please welcome to the percent passing program, please enter all your grades. If you are done please enter '000' as shown here.");
            user = Convert.ToInt32(Console.ReadLine());

            while (user != done) {

                if (user >= 70) {

                    above = above + 1;
                    total = total + 1;
                        Console.WriteLine("Thank you, youve entered " + total + " please enter all your grades. If you are done please enter '000' as shown here.");
                    user = Convert.ToInt32(Console.ReadLine());
                }
                else if (user < 70) {
                    
                    total = total + 1;
                    Console.WriteLine("Thank you, youve entered " + total + " please enter all your grades. If you are done please enter '000' as shown here.");
                    user = Convert.ToInt32(Console.ReadLine());
                }
            }

            result = (((double)above / total) * 100);
            Console.WriteLine("Thank you, the percentgae of your class that is passing is " + result + "%");

             



                }
    }
}
