using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace All_types_programs
{
    internal class Program
    {
        //int a = 5, b = 10;
        //double c = 20.5;

        //public void sum()
        //{
        //    int sum = a + b;
        //Console.WriteLine("Sum of a and b is: " + sum);

        //}
        //public void decimalvalue()
        //{

        //    Console.WriteLine("Decimal value is : "+(a+b+c));

        //}
        //public void average()
        //{
        //    double sum = (a + b + c)/3;
        //    Console.WriteLine("Average of 3 numbers: " + sum);
        //}

        //public void Q()
        //{ 
        //    int q = b/a;
        //    Console.WriteLine("Quotient is: " + q);
        //}
        //public void R()
        //{
        //    int r = a % b;
        //    Console.WriteLine("Remiander is: " + r);
        //}

        //public void fristnumber()
        //{
        //    int n = 4, sum = n * (n + 1) / 2;
        //    Console.WriteLine("frist N numbers :" + sum);
        //}
        //public void lastnumber()
        //{
        //    int l = 786,  sum = l % 10;
        //    Console.WriteLine("last N numbers :" + sum);
        //}
        //public void removel_number()
        //    {
        //    int rn = 786, sum = rn / 10;    
        //    Console.WriteLine("remove last N numbers :" + sum);
        //}
        //public void squareandcube()
        //{
        //    Console.Write("Enter a number to find its square value:");
        //    int square = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter a number to find its cube value :");
        //    int cube = Convert.ToInt32(Console.ReadLine());
        //    int s = square * square;
        //    int c = cube * cube * cube;
        //    Console.WriteLine("square value :" + s);
        //    Console.WriteLine("cube value :" + c);
        //}
        //public void swapping()
        //{
        //    int a = 5;
        //    int b = 3;
        //    int c = b;
        //    a = a + b;
        //    b = a - b;
        //    a = a - b;
        //    Console.WriteLine("a is "+a);
        //    Console.WriteLine("b is "+b);


        //}
        //public void swapping_without_3var()
        //{
        //    int a = 5;
        //    int b = 3;

        //    a = a + b;
        //    b = a - b;
        //    a = a - b;
        //    Console.WriteLine("a is " + a);
        //    Console.WriteLine("b is " + b);
        //}
        //public void totalsalary()
        //{
        //    double basicsal = 5000;
        //    double hra = basicsal * 12 / 100;
        //    double da = basicsal * 5 / 100;
        //    double ta = basicsal * 5 / 100;
        //    double pf = basicsal * 7 / 100;
        //    double esic = basicsal * 3 / 100;
        //    double totalsal = basicsal + hra + da + ta - pf - esic;
        //    Console.WriteLine("Total salary is : " + totalsal);
        //}
        //public void Areaofcircle()
        //{
        //    Console.Write("Enter radius of circle : ");
        //    double r = Convert.ToDouble(Console.ReadLine());
        //    double area = 3.14 * r * r;
        //    Console.WriteLine("Area of circle is : " + area);
        //}
        //public void lastdigit()
        //{
        //    Console.Write("Enter a number to find its last digit : ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    int lastdigit = number % 10;
        //    Console.WriteLine("Last digit of " + number + " is : " + lastdigit);
        //}
        //public void anemployee()
        //{
        //    double basicsal = 100000.0;
        //    double hra = basicsal * 30 / 100;
        //    double da = basicsal * 20 / 100;
        //    double totalsal = basicsal + hra + da;
        //    Console.WriteLine("Total salary is :" + totalsal);
        //}
        //public void profit()
        //{
        //    double pamt = 255000.56;
        //    double tax = pamt * 18 / 100;
        //    double netprofit = pamt - tax;
        //    Console.WriteLine("Net profit is : " + netprofit);
        //    Console.WriteLine("Tax amount is : " + tax);
        //  Console.WriteLine("Profit amount is : " + pamt);
        //}
        //public void inr_to_usd()
        //{

        //    double inr = 650000.0;
        //    double usd = inr / 82.74;
        //    Console.WriteLine("Amount in USD is : " + usd);
        //}
        //public void splitamt()
        //{
        //   double amount = 1507500.0;
        //    double spilt1 = 1507500.0 / 6;
        //    Console.WriteLine("per person amount is : " + spilt1);
        //}
        //public void totalbill()
        //{
        //    double roomcharge = 2500.0;
        //    int d = 5;
        //    double mecidinecharge = 3000.0;
        //    double doctorfee = 5000.0;
        //    double duration = d * roomcharge;
        //    double doctor1 = duration * doctorfee;
        //    double totalbill = duration + (mecidinecharge*d) + doctorfee;
        //    Console.WriteLine("Per day Charges");
        //    Console.WriteLine("Room charge is : " + roomcharge);
        //    Console.WriteLine("Mecidine charge is : " + mecidinecharge);
        //    Console.WriteLine("Duration charge is : " + d);
        //    Console.WriteLine("Doctor fee is : " + doctorfee);
        //    Console.WriteLine("");
        //    Console.WriteLine("For"+" "+d+" "+"days");
        //    Console.WriteLine("Total bill amount is : " + totalbill);
        //}
        //public void annualplan()
        //{
        //    double anuualp = 24000.0;
        //    double monthlyp = anuualp / 12;
        //    Console.WriteLine("Annual plan is : " + anuualp);
        //    Console.WriteLine("Monthly plan is : " + monthlyp);
        //}
        //public void lifeinsurance()
        //{
        //    double policyamount = 500000.0;
        //    int duration = 10;
        //    double rateofinterest = 5;
        //    double rot = policyamount * rateofinterest * duration / 100;
        //    double totalamount = policyamount + rot;
        //    Console.WriteLine("Policy amount is : " + policyamount);
        //    Console.WriteLine("Rate of interest is : " + rateofinterest+ "%");
        //    Console.WriteLine("Duration is : " + duration + " " + "years");
        //    Console.WriteLine("Total amount after maturity is : " + totalamount);
        //}
        //public void emp()
        //{
        //    Console.WriteLine("Enter Employee Details");
        //    Console.Write("Enter ID :");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter name :");
        //    string n = Console.ReadLine();
        //    Console.Write("Enter salary :");
        //    double sal = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Details Entered :" + id + "," + n + "," + sal);

        //}
        //public void user()
        //{
        //    Console.Write("Enter your username :");
        //    string a = Console.ReadLine();
        //    Console.Write("Enter your password :");
        //    string b = Console.ReadLine();
        //    if (a == "venket" && b == "sathya@123")
        //    {
        //        Console.WriteLine("Valid user");

        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid user");

        //    }
        //}
        //public void cust()
        //{
        //    double amt = 6000.0;
        //    Console.Write("Enter the withdraw amount :");
        //    double wa = Convert.ToDouble(Console.ReadLine());
        //    if (wa > 6000.0)
        //    {
        //        Console.WriteLine("sorry..! You have low funds...");
        //    }
        //    if (wa <= 6000.0)
        //    {
        //        amt = amt - wa;
        //        Console.WriteLine("Your balance is :" + amt);
        //        Console.WriteLine("Withdraw amount is :" + wa);
        //    }
        //}
        //public void temperature()
        //{
        //    Console.Write("Enter the current Temperature :");
        //    double tmp = Convert.ToDouble(Console.ReadLine());
        //    if (tmp > 35)
        //    {
        //        Console.WriteLine("Temperature is :" + tmp);
        //        Console.WriteLine("Hot day");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Temperature is :" + tmp);
        //        Console.WriteLine("Normal day");
        //    }
        //}
        //public void birth()
        //{
        //    Console.Write("Enter the brith year :");
        //    int year = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter the current year :");
        //    int  current = Convert.ToInt32(Console.ReadLine());
        //    int age = current - year;
        //    if (age >= 18)
        //    {
        //        Console.WriteLine("Your age is :" + age);
        //        Console.WriteLine("Major");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Your age is :" + age);
        //        Console.WriteLine("Minor");
        //    }
        //}
        //public void divisble3_5()
        //{
        //    Console.WriteLine("if you want check a number is divisible by 3 or 5");
        //    Console.Write("Enter a number :");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    if(n%3 == 0 || n%5 ==0 )
        //    {
        //        Console.WriteLine("It is divisible");
        //    }
        //    else
        //    {
        //        Console.WriteLine("It is not divisible");
        //    }

        //}
        //public void km()
        //{
        //    Console.Write("Enter distances do you travelled :");
        //    int km = Convert.ToInt32(Console.ReadLine());
        //    if(km > 10)
        //    {
        //        km = km * 8;

        //        Console.WriteLine("total amount :" + km);
        //    }
        //    else
        //    {
        //        km = km * 10;

        //        Console.WriteLine("total amount :" + km);

        //    }
        //}
        //public void marks()
        //{
        //    Console.Write("Enter subjects-1 marks :");
        //    int sub1 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter subjects-2 marks :");
        //    int sub2 = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter subjects-3 marks :");
        //    int sub3 = Convert.ToInt32(Console.ReadLine());
        //    if ((sub1 > 0 && sub1 <= 100) && (sub2 > 0 && sub2 <= 100) && (sub3 > 0 && sub3 <= 100))
        //    {
        //        Console.WriteLine("Valid marks");


        //    }
        //    else
        //    {


        //        Console.WriteLine("Invalid marks");
        //    }
        //}

        //public void product()
        //{
        //    Console.Write("Product Cost :");
        //    double p = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Quantity :");
        //    int q = Convert.ToInt32(Console.ReadLine());
        //    int d = 0 ;
        //    double totalbill = p * q ;
        //    if (totalbill >= 5000.0)
        //    {
        //        d = d + 20;
        //        Console.WriteLine("Discount is 20%");

        //    }

        //        double disamt = p * d / 100;
        //        totalbill = totalbill - disamt;
        //        Console.WriteLine("Final bill :" + totalbill);
        //    }
        //public void emp_tax()
        //{
        //    Console.Write("Enter your annual salary :");
        //    double sal = Convert.ToDouble(Console.ReadLine());
        //    double msal = sal / 12;
        //    if (msal >= 50000.0)
        //    {

        //        double tax = msal * 20 / 100;
        //        msal = msal - tax;
        //        Console.WriteLine("You need to pay tax amount is :" + tax);

        //    }
        //    else
        //    {
        //        Console.WriteLine("No need to pay");
        //    }
        //    Console.WriteLine(" Your Monthly salary is :" + msal);
        //}
        //public void amazon()
        //{
        //    Console.Write("Enter product cost :");
        //    double p = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Enter product quantity :");
        //    int q = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter card name :");
        //    String card = Console.ReadLine();
        //    int d = 0;
        //    double billamt = p * q;
        //    if( card == "ICICI")
        //    {
        //        d = d + 20;
        //        double disamt = p * d / 100;
        //        billamt =  billamt - disamt;
        //        Console.WriteLine("Discount amount is :" + disamt);

        //    }
        //   Console.WriteLine("Total bill is :"+ billamt);
        //} 
        //public void tickets()
        //{
        //    Console.Write("Enter tickets price :");
        //    double t = Convert.ToDouble(Console.ReadLine());
        //    Console.Write("Enter no.of tickets :");
        //    int i = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter no.of Cuopen Code :");
        //    String s = Console.ReadLine();
        //    int d = 0;
        //    if( s == "SAVE20")
        //    {
        //        d = d + 20;
        //        Console.WriteLine("Discount amount is :"+ d+"%");

        //    }
        //    double billamt = (t * i) - d/100;
        //    Console.WriteLine("Total bill is :"+ billamt);
        //}
        //public void age()
        //{
        //    Console.Write("Enter your age :");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    if(age >= 18)
        //    {
        //        Console.WriteLine("major");

        //    }
        //    else
        //    {
        //        Console.WriteLine("minor");
        //    }

        //}
        //public void bank()
        //{
        //    Console.Write("Enter your amount :");
        //    double amt = Convert.ToDouble(Console.ReadLine());
        //    double r = 0;
        //    double rot = 0;


        //    if (amt > 0 && amt <= 50000.0)
        //    {
        //        r = 2;
        //        rot = amt * r / 100;
        //    }
        //    else if (amt > 50000.0 && amt <= 100000.0)
        //    {
        //        r = 3;
        //        rot = amt * r / 100;
        //    }
        //    else if (amt > 100000.0 && amt <= 200000.0)
        //    {   r = 4;
        //        rot = amt * r / 100;
        //    }
        //    else if (amt > 200000.0)
        //    {   
        //        r = 5;
        //        rot = amt * r / 100;
        //    }
        //    double bamt= amt - rot;
        //    Console.WriteLine("The rate of interest :" + r + "%");
        //    Console.WriteLine("Total balance is :" + bamt);
           

        //}
        public void 









                public static void Main(string[] args)
                {
                    Program p1 = new Program();
            //p1.bank();
            //p1.age();
            //p1.tickets();
            //p1.amazon();
            //p1.emp_tax();
            //p1.product();
            //p1.marks();
            //p1.km();
            //p1.divisble3_5();
            //p1.birth(); 
            //p1.temperature();
            //p1.cust();
            //p1.user();
            //p1.sum();
            //p1.decimalvalue();
            //p1.average();
            //p1.Q();
            //p1.R();
            //p1.fristnumber();
            //p1.lastnumber();
            //p1.removel_number();
            //p1.squareandcube();
            //p1.swapping();
            //p1.swapping_without_3var(); 
            //p1.totalsalary();
            //p1.Areaofcircle();
            //p1.lastdigit();
            //p1.anemployee();
            //p1.profit();
            //p1.inr_to_usd();
            //p1.splitamt();
            //p1.totalbill();
            //p1.annualplan();
            //p1.lifeinsurance();
            //p1.emp();










        }
    }
}
