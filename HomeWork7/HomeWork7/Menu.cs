using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Menu
    {
        List<Employee> EmployeeList = new List<Employee>
        {
            new Doctor() { name = "Иван Иванов" },
            new Psychologist() { name = "Петр Петров" },
            new OrdinaryWorker() { name = "Василий Васильев" },
            new SecurityGuard() { name = "Мария Марьянова" }
        };
        List<Trainee> TraineeList = new List<Trainee>
        {
            new Trainee(new Doctor()){ name = "Ольга"},
            new Trainee(new Psychologist()) { name = "Олег" },
            new Trainee(new OrdinaryWorker()) { name = "Руслан" },
            new Trainee(new SecurityGuard()) { name = "Максим" }
        };
        //основное меню
        public void MainMenu()
        {
            string selection = "";
            while ( selection !="5" )
            {
                Console.Clear();
                Console.WriteLine("1. Добавить работника\n2. Добавить стажера\n3. Расчитать оплату сотрудника\n4. Расчитать оплату стажеру\n\n5. Выход");
                Console.Write("\n Введите номер пункта меню ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        {
                            AddEmployeeMenu();
                        }
                        break;
                    case "2":
                        {
                            AddTraineeMenu();
                        }
                        break;
                    case "3":
                        {
                            CalculationsForEmployees();
                        }
                        break;
                    case "4":
                        {
                            CalculationsForTrainee();
                        }
                        break;
                    case "5":
                        {
                            // Выход
                        }
                        break;
                    default:
                        Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                        Console.ReadKey();
                        continue;
                }
            }
        }
        //меню добавления сотрудника
        private void AddEmployeeMenu()
        {
            string selection="";
            Console.Clear();
            Console.Write("Введите ФИО сотрудника: ");
            string name = Console.ReadLine();
            while (selection != "5")
            {
                Console.Clear();
                Console.WriteLine("\tВыберите профессию\n1. Врачь\n2. Психолог\n3. Работник\n4. Охранник\n");
                Console.Write("\n Введите номер пункта меню ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        {
                            EmployeeList.Add(new Doctor() { name = name });
                            Console.WriteLine("Сотрудник добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "2":
                        {
                            EmployeeList.Add(new Psychologist() { name = name });
                            Console.WriteLine("Сотрудник добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "3":
                        {
                            EmployeeList.Add(new OrdinaryWorker() { name = name });
                            Console.WriteLine("Сотрудник добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "4":
                        {
                            EmployeeList.Add(new SecurityGuard() { name = name });
                            Console.WriteLine("Сотрудник добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    default:
                        Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                        Console.ReadKey();
                        continue;
                }
            }
        }
        //меню добавления стажера
        private void AddTraineeMenu()
        {
            string selection = "";
            Console.Clear();
            Console.Write("Введите ФИО стажера: ");
            string name = Console.ReadLine();
            while (selection != "5")
            {
                Console.Clear();
                Console.WriteLine("\tУ кого он стажируется?\n1. Врачь\n2. Психолог\n3. Работник\n4. Охранник\n");
                Console.Write("\n Введите номер пункта списка ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        {
                            TraineeList.Add(new Trainee(new Doctor()){ name = name });
                            Console.WriteLine("Стажер добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "2":
                        {
                            TraineeList.Add(new Trainee(new Psychologist()) { name = name });
                            Console.WriteLine("Стажер добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "3":
                        {
                            TraineeList.Add(new Trainee(new OrdinaryWorker()) { name = name });
                            Console.WriteLine("Стажер добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    case "4":
                        {
                            TraineeList.Add(new Trainee(new SecurityGuard()) { name = name });
                            Console.WriteLine("Стажер добавлен\nНажмиту любую клавишу");
                            Console.ReadKey();
                            selection = "5";
                        }
                        break;
                    default:
                        Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                        Console.ReadKey();
                        continue;
                }
            }
        }
        //список сотрудников
        private void ShowEmployeeList()
        {
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i+1, EmployeeList[i].name);
            }
        }
        //список стажеров
        private void ShowTraineeList()
        {
            for (int i = 0; i < TraineeList.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, TraineeList[i].name);
            }
        }
        //расчеты для сотрудников
        private void CalculationsForEmployees()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tВыбирите сотрудника\n ");
                ShowEmployeeList();
                Console.Write("\n Введите номер пункта списка ");
                string selection = Console.ReadLine();
                byte byteSelection = 0;
                if ((Byte.TryParse(selection, out byteSelection) && (byteSelection <=EmployeeList.Count)))
                {
                    byteSelection = Convert.ToByte(selection);
                    --byteSelection;
                    Employee thisEmployee = EmployeeList[byteSelection];
                    Console.Clear();
                    thisEmployee.DataInput();
                    thisEmployee.CalculationBonuses();
                    thisEmployee.CalculationSalary();
                    break;
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                    continue;
                }
            }
        }
        //расчеты для стажеров
        private void CalculationsForTrainee()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\tВыбирите стажера\n ");
                ShowTraineeList();
                Console.Write("\n Введите номер пункта списка ");
                string selection = Console.ReadLine();
                byte byteSelection = 0;
                if ((Byte.TryParse(selection, out byteSelection) && (byteSelection <= TraineeList.Count)))
                {
                    byteSelection = Convert.ToByte(selection);
                    --byteSelection;
                    Trainee thisTrainee = TraineeList[byteSelection];
                    Console.Clear();
                    thisTrainee.mentor.DataInput();
                    thisTrainee.CalculationBonuses();
                    thisTrainee.mentor.CalculationSalary();
                    break;
                }
                else
                {
                    Console.WriteLine("Это не верное значение\nНажмиту любую клавишу");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
