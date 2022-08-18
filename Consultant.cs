using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankConsoleApp
{
    internal class Consultant : User
    {
        public Consultant(string name)
        {
            Name = name;
        }

        public override void ChangeClient(Client client)
        {
            Console.WriteLine("Введите новый телефон");
            var inputLine = Console.ReadLine();

            if (inputLine != null)
            {
                var symbols = inputLine.ToCharArray();
                var flag = false;
                foreach (var symbol in symbols)
                {
                    Console.WriteLine(symbol);
                    if (int.TryParse(symbol.ToString(), out _) == false)
                    {
                        flag = true;
                        Console.WriteLine("Введены не цифры");
                        break;
                    }
                }

                if (flag == false)
                {
                    client.Phone = inputLine;
                    Console.WriteLine($"Телефон {inputLine} сохранен");
                }
            }
            else Console.WriteLine("Поле телефон должно быть заполнено");
        }

        public override void SeeClient(Client client)
        {
            Console.WriteLine($"{client.SecondName} {client.FirstName} {client.ThirdName} ********** {client.Phone}");
        }
    }
}
