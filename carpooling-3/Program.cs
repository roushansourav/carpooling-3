using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace carpooling_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:\n1)Valid Car registration Number\n2)Convert Car registration Number\n3)Valid Driving License\nEnter Choice");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("car registration number");
                    string s= Console.ReadLine();
                    string pattern=@"^[A-Z]{2}-[0-9]{2}-[A-Z]{2}-[0-9]{4}$";
                    Match m = Regex.Match(s, pattern);
                    if(m.Success)
                    {
                        Console.WriteLine(s+" is Valid");
                    }
                    else
                        Console.WriteLine(s+" is Invalid");
                    break;
                case 2:
                    Console.WriteLine("car registration number");
                    s = Console.ReadLine();
                    char[] ch = s.ToCharArray();
                    ch[2] = '-'; ch[5] = '-'; ch[8] = '-';
                    for (int i = 0; i < ch.Length; i++)
                        Console.Write(ch[i]);

                    break;
                case 3:
                    Console.WriteLine("driving license issue date");
                    DateTime ldate = DateTime.Parse(Console.ReadLine());
                    DateTime currentdate = DateTime.Parse("15 - 06 - 2017");
                    int years = (int)Math.Round((currentdate - ldate).TotalDays / 365);
                    if (years<=10)
                    {   
                        
                        Console.WriteLine( years+"years old license -valid");
                    }
                    else
                        Console.WriteLine(years + "years old license -expired");
                    break;

            }

            
        }
    }
}
