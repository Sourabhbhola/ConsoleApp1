using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
    
        static void Main(string[] args)
        {
            int choice, l=0, b=0, h=0,i=0;
            // initializing variables
           
                do
                {
                
                    Console.WriteLine("Enter  the correct options: ");
                    Console.WriteLine("1.Enter triangle's dimensions");
                    Console.WriteLine("2.Exit");
                    if ((!int.TryParse(Console.ReadLine(), out choice) || choice <= 0 || choice > 2)) // checking user input
                    {
                        Console.WriteLine("Please Enter the Correct option: ");
                        continue;
                    }
                
                    switch (choice)
                    {

                        case 1:
                        

                            do {
                            do { 
                            Console.WriteLine("Please Enter the First Side of the Triangle: ");
                       
                } while (!int.TryParse(Console.ReadLine(), out l));

                        } while (l <= 0);



                        do
                            {

                            do { 
                                    Console.WriteLine("Please Enter the Second Side of the Triangle: ");
                        
                } while (!int.TryParse(Console.ReadLine(), out b));
                        } while (b <= 0);
                        do
                        {
                            do
                            {
                                Console.WriteLine("Please Enter the third Side of the Triangle: ");
                             
                            } while (!int.TryParse(Console.ReadLine(), out h));
                        } while (h <= 0);
                        break;

                        case 2:
                            Environment.Exit(0);
                            break;
                    }
                    i++;
                
                Console.WriteLine(TriangleSolver.Analyze(l, b, h));
            } while (choice != 2);

            }
        }
    }
