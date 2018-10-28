using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tower_of_Hanoi_Console_Project
{
    class Program
    {
        

        static void Main(string[] args)
        {
            double moves;
            double totalmoves;
            double based = 2;
            

            Console.WriteLine("               Tower of Hanoi");


            Console.WriteLine("\n");

            Console.Write("Please Enter No. of Disks : ");
            double disks = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            while (disks > 9)
            {
                Console.Write("Please enter disks between 1 to 9 : ");
                disks = int.Parse(Console.ReadLine());
            }
                if (disks<=9)
                {
                    Console.WriteLine("\n");

                    TOH(disks, 'a', 'c', 'b');
                }
                
            

            moves = Math.Pow(based, disks);
            totalmoves = moves - 1;

            Console.WriteLine("\n");
            Console.WriteLine("Total Number of Moves are : "+totalmoves);


            Console.ReadKey();
        }

        static void TOH(double ndisks, char source, char dest, char aux)
        {
            if (ndisks == 1)
            {
                Console.WriteLine("Move Disk 1 from tower " + source + " to tower " + dest);
                return;
            }
            
                TOH(ndisks - 1, source, aux, dest);
                Console.WriteLine("Move disk " + ndisks + " from tower " + source + " to tower " + dest);
                TOH(ndisks - 1, aux, dest, source);
              
        }

    }
}
