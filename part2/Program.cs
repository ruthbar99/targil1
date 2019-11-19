//Ruth Bar Dagan ID:208317735
//Yael Suisa ID:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//enum Option
//{
//    Exit, customerDemands, DataDisplay, percentages
//}
namespace part2
{
    class Program
    {

        static void Main(string[] args)
        {       
            bool[,] mat = new bool[12, 31];
            for (int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    mat[i, j] = false;
                }
            }
            // choose = Console.ReadLine();
            int choose;
            do
            {
                Console.WriteLine("Type your choice (customerDemands / DataDisplay / percentages / Exit): ");
                choose = int.Parse(Console.ReadLine());
                
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter a day :");
                        int day = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter a mounth :");
                        int mounth = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert desired number of days:");
                        int days = int.Parse(Console.ReadLine());
                        int d = day;
                        //  while ()
                        {
                            mounth = mounth + 1;

                        }



                        break;

                    case 2:
                        Console.WriteLine(" DataDisplay");
                        break;

                    case 3:
                        int count = 0;
                        for (int i = 0; i < 12; ++i)
                        {
                            for (int j = 0; j < 31; ++j)
                            {
                                if (mat[i, j] == true)
                                    count++;
                            }
                        }
                        int present = (count / 365) * 100;
                        Console.WriteLine("The number of busy days per year" + count);
                        Console.WriteLine("Percentage of annual occupancy" + present);
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;

                }
            }
            while (choose != 0);
            for(int i = 0; i < 12; ++i)
            {
                for (int j = 0; j < 31; ++j)
                {
                    if (mat[i, j] == false)
                        break;
                    else if (mat[i, j] == true && mat[i, j - 1] == false)
                        Console.WriteLine("start date "+i + "/" + j);
                    else if (mat[i, j] == true && mat[i, j + 1] == false)
                        Console.WriteLine("end date " + i + "/" + j);
                }
            }
            
        }
    }
} 
    
  
    
