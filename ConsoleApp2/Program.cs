using System;

class Program
{
    static void Main(string[] args)
    {
        //while (true)
        //{
        //    Console.Clear();
        //    Console.WriteLine("Калькулятор для перевода чисел между системами счисления");
        //    Console.WriteLine("1. Десятичная -> Двоичная");
        //    Console.WriteLine("2. Двоичная -> Десятичная");
        //    Console.WriteLine("3. Десятичная -> Шестнадцатеричная");
        //    Console.WriteLine("4. Шестнадцатеричная -> Десятичная");
        //    Console.WriteLine("5. Выход");
        //    Console.Write("Ваш выбор: ");

        //    string menuChoice = Console.ReadLine();

        //    if (menuChoice == "5") break;

        //    Console.Write("Введите число: ");
        //    string userInput = Console.ReadLine();

        //    try
        //    {
        //        int number;

        //        if (menuChoice == "1")
        //        {
        //            number = int.Parse(userInput);
        //            Console.WriteLine($"Двоичное представление: {Convert.ToString(number, 2)}");
        //        }
        //        else if (menuChoice == "2")
        //        {
        //            number = Convert.ToInt32(userInput, 2);
        //            Console.WriteLine($"Десятичное представление: {number}");
        //        }
        //        else if (menuChoice == "3")
        //        {
        //            number = int.Parse(userInput);
        //            Console.WriteLine($"Шестнадцатеричное представление: {number:X}");
        //        }
        //        else if (menuChoice == "4")
        //        {
        //            number = Convert.ToInt32(userInput, 16);
        //            Console.WriteLine($"Десятичное представление: {number}");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Неверный выбор.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Ошибка: {ex.Message}");
        //    }

        //    Console.WriteLine("Нажмите любую клавишу для продолжения...");
        //    Console.ReadKey();
        //}

        //Task 2
    }
    public class Passport{

        private string number;
        private string owner;
        private DateTime issueDate;
        private DateTime expirationDate;

        public string Number
        {
            get { return number; }
            set
            {
                if (value == null || value.Length != 9)
                    throw new ArgumentException("Номер паспорта должен состоять из 9 символов.");
                number = value;
            }
        }

        public string Owner
        {
            get { return owner; }
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("ФИО владельца не может быть пустым.");
                owner = value;
            }
        }

        public DateTime IssueDate
        {
            get { return issueDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Дата выдачи не может быть в будущем.");
                issueDate = value;
            }
        }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (value <= issueDate)
                    throw new ArgumentException("Дата истечения срока должна быть позже даты выдачи.");
                expirationDate = value;
            }
        }

        public Passport(string number, string owner, DateTime issueDate, DateTime expirationDate)
        {
            Number = number;
            Owner = owner;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
        }

        public override string ToString()
        {
            return $"Паспорт: {Number}, Владелец: {Owner}, Дата выдачи: {IssueDate.ToShortDateString()}, " +
                    $"Дата истечения: {ExpirationDate.ToShortDateString()}";
        }
    }
}


