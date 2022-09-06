using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class subscriber
        {
            string Login;
           int IP;
            string Mail;
            int Data;
            public void input()
            {
               
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(" Какое поле заполнить?\n1 Логин\n2 IP\n3 Почта\n4 Дата договора\n");
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 1)
                    {
                        Console.WriteLine("Ваш логин ");
                        Login = Console.ReadLine();
                    }
                    if (a == 2)
                    {
                        Console.WriteLine("Ваш IP ");
                        IP = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("заполнено");

                    }
                    if (a == 3)
                    {
                        Console.WriteLine("Ваша почта ");
                        Mail = Console.ReadLine();
                    }
                    if (a == 4)
                    {
                        Console.WriteLine("Дата договора ");
                        Data = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            public void show()
            {
                Console.WriteLine(Login);
                Console.WriteLine(IP);
                Console.WriteLine(Mail);
                Console.WriteLine(Data);
               
            }
        }
        static void Main(string[] args)
        {
           
            subscriber subscriber = new subscriber();
            
            
            subscriber.input();


            //subscriber.show();  
        }
    }
}
