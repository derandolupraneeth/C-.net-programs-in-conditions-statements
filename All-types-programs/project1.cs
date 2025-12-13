using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Project
    {
        public void menus()
        {
            Console.WriteLine("Welcome to Hotel Sathya");
            Console.WriteLine("1.Idly(4pcs) - Rs.50.0");
            Console.WriteLine("2.Masala Dosa - Rs.75.0");
            Console.WriteLine("3.Mysore Baji(4 pcs) - Rs.50.0");
            Console.WriteLine("4.Vada - Rs.60.0");
            Console.WriteLine("5.Upma - Rs.30.0");
            Console.WriteLine("6.Onion Dosa - Rs.50.0");
            Console.WriteLine("7.Puri(2pcs) - Rs.50.0");
            Console.WriteLine("8.Sambar Idli - Rs.60.0");
            Console.WriteLine("9.Paneer Dosa - Rs. 85.0");
            Console.WriteLine("10.Chicken kheema Dosa - Rs.90.0");
            Console.WriteLine("11.Mutton Kheema Dosa - Rs.140.0");
            Console.WriteLine(" ");
            Console.Write("Enter Your Choice : ");
            int choice = Convert.ToInt32(Console.ReadLine());
            double dis = 0;
            double amt = 0;

            if (choice > 0 && choice <= 11)
            {
                if (choice > 0 || choice <= 11)
                {
                    Console.Write("Enter Your Quantity : ");
                    int q = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        amt = 50.0 * q;

                        Console.WriteLine("Iteam Name is : Idly(4pcs)");
                        Console.WriteLine("Cost is  :" + amt);
                    }
                    else if (choice == 2)
                    {
                        amt = 75.0 * q;
                        Console.WriteLine("Iteam Name is : Masala Dosa");
                        Console.WriteLine("Cost :" + amt);
                    }

                    else if (choice == 3)
                    {
                        amt = 50.0 * q;
                        Console.WriteLine("Iteam Name is : Mysore Baji(4 pcs)");
                        Console.WriteLine("Cost :" + amt);

                    }
                    else if (choice == 4)
                    {
                        amt = 60.0 * q;
                        Console.WriteLine("Iteam Name is : Vada");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 5)
                    {
                        amt = 30.0 * q;
                        Console.WriteLine("Iteam Name is : Upma");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 6)
                    {
                        amt = 50.0 * q;
                        Console.WriteLine("Iteam Name is : Onion Dosa");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 7)
                    {
                        amt = 50.0 * q;
                        Console.WriteLine("Iteam Name is : Puri(2pcs)");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 8)
                    {
                        amt = 60.0 * q;
                        Console.WriteLine("Iteam Name is : Sambar Idli");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 8)
                    {
                        amt = 85.0 * q;
                        Console.WriteLine("Iteam Name is : Paneer Dosa");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 10)
                    {
                        amt = 90.0 * q;
                        Console.WriteLine("Iteam Name is : Chicken kheema Dosa");
                        Console.WriteLine("Cost :" + amt);
                    }
                    else if (choice == 11)
                    {
                        amt = 140.0 * q;
                        Console.WriteLine("Iteam Name is : Mutton Kheema Dosa ");
                        Console.WriteLine("Cost :" + amt);
                    }
                }
                if (amt >= 300.0)
                {
                    dis = 20.0;
                    amt = amt - (amt * dis / 100);
                    Console.WriteLine("Discount is " + dis + "%");
                    Console.WriteLine("Total Bill is " + amt);
                    Console.Write("Enter Paid Amount is :");
                    double pamt = Convert.ToDouble(Console.ReadLine());
                    double balance = pamt - amt;
                    Console.WriteLine("Balance is " + balance);
                }
                if (amt < 300)
                {

                    Console.WriteLine("Total Bill is " + amt);
                    Console.WriteLine("Discount Amount " + dis + "%");
                    Console.Write("Enter Paid Amount is :");
                    double pamt = Convert.ToDouble(Console.ReadLine());
                    double balance = pamt - amt;
                    Console.WriteLine("Balance is " + balance);
                }

            }

            else
            {
                Console.WriteLine("Sorry..! Invalid Choice");
            }
        }

        public static void Main(string[] args)
        {
            Project p2 = new Project();
            p2.menus();
        }
    }
}
