//Ruth Bar Dagan ID:208317735
//Yael Suisa ID:318905114
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
                        //Console.WriteLine("Enter a day :");
                        //int day = int.Parse(Console.ReadLine());
                        //Console.WriteLine("Enter a mounth :");
                        //int mounth = int.Parse(Console.ReadLine());
                        //Console.WriteLine("Insert desired number of days:");
                        //int days = int.Parse(Console.ReadLine());
                        //int d = day;
                        ////  while ()
                        //{
                        //    mounth = mounth + 1;

                        //}
                        //for check-in date and duration
                        int day, month, dur;
                        Console.WriteLine("enter check-in date:");
                        Console.WriteLine("day: ");
                        day = int.Parse(Console.ReadLine());
                        Console.WriteLine("month: ");
                        month = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter duration of vacation: ");
                        dur = int.Parse(Console.ReadLine());
                        //Flag, if it is false left out of the loop.
                        bool flag = true;
                        int d = day, m = month;
                        //Checking whether catch on this day he ask.
                        for (int i = 2; i < dur; i++)
                        {
                            if (mat[m, d] == true)
                            {
                                flag = false;
                                break;
                            }
                            //Promote date
                            if (d == 31)
                            {
                                d = 1;
                                if (m == 12)
                                {
                                    m = 1;
                                }
                                else
                                    m++;
                            }
                            else
                                d++;
                        }
                        d = day;
                        m = month;
                        //There is free space
                        if (flag)
                        {
                            Console.WriteLine("success");
                            for (int i = 1; i < dur; i++)
                            {
                                mat[m, d] = true;
                                if (d == 31)
                                {
                                    d = 1;
                                    if (m == 12)
                                    {
                                        m = 1;
                                    }
                                    else
                                        m++;
                                }
                                else
                                    d++;
                            }
                        }
                        //There isn't.
                        else
                            Console.WriteLine("fail");

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
    
  
    
