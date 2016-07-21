using System;

namespace Homework3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayRole = new string[] { "Admin", "Moderator", "Moderator", "User", "User" };
            string[] arrayLogin = new string[] { "Admin11", "Moder333", "Moderator1", "Vasya", "L97" };
            string[] arrayPassword = new string[] { "admpas", "modpas", "pwd", "vasya82", "111111" };

            Console.Write("Enter your login:");
            string login = Console.ReadLine();
            //поверка логина
            for (int i = 0; i < arrayLogin.Length; i++)
            {
                if (login == arrayLogin[i])
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write("Enter your password:");
                        string password = Console.ReadLine();
                        //проверка пароля
                        if (password == arrayPassword[i])
                        {
                            //проверка роли
                            switch (arrayRole[i])
                            {
                                case "Admin":
                                    {
                                        for (int k = 0; k < arrayLogin.Length; k++)
                                        {
                                            Console.WriteLine("{0}: Login-{1}, Password-{2}", arrayRole[k], arrayLogin[k], arrayPassword[k]);
                                        }
                                    };
                                    break;
                                case "Moderator":
                                    {
                                        Console.WriteLine("{0} users", arrayLogin.Length);
                                    };
                                    break;
                                default:
                                    { 
                                    int countUsers = 0;
                                    string loginUsers = "";

                                    for (int l = 0; l < arrayRole.Length; l++)
                                    {
                                        if (arrayRole[l] == "User")
                                        {
                                            countUsers++;
                                            loginUsers += arrayLogin[l] + "; ";
                                        }
                                    }
                                    Console.WriteLine("{0} users: {1}", countUsers, loginUsers);
                                }
                                break;
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password is incorrect");
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
