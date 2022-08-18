using System.Collections.ObjectModel;
using BankConsoleApp;

var allClients = new ObservableCollection<Client>();
allClients.Add(new Client(1, "Nikita","Belov","Petrovich","4500800008","88005553501"));
allClients.Add(new Client(2, "Petr", "Skvorcov","Sergeevich","4501200002","88005553502"));
allClients.Add(new Client(3, "Ivan","Petrov","Klimovich","4599333003","88005553535"));

Console.WriteLine("Выберите роль: 1 - консультант");
var inputRole = Console.ReadLine();
switch (inputRole)
{
    case "1":
        Console.Write("Вы зашли как консультант\nВведите ваше имя: ");
        var userName = Console.ReadLine();
        if (!string.IsNullOrEmpty(userName))
        {
            var user = new Consultant(userName);
            ClientInteractionConsultant(user);
        }
        else Console.WriteLine("У Консультанта должно быть имя");
        break;
    default:
        Console.WriteLine("Wrong input");
        break;
}

void ClientInteractionConsultant(Consultant user)
{
    Console.Write("1 - для просмотра клиента;\n2 - для редактирования телефона: ");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.Write("Введите id клиента: ");
            var flag1 = int.TryParse(Console.ReadLine(), out var id1);
            if (flag1 == true && id1 > 0 && (id1 - 1) < allClients.Count)
            {
                user.SeeClient(allClients[id1 - 1]);
            }
            else Console.WriteLine("Wrong input");
            break;
        case "2":
            Console.Write("Введите id клиента: ");
            var flag2 = int.TryParse(Console.ReadLine(), out var id2);
            if (flag2 == true && id2 > 0 && (id2-1) < allClients.Count)
            {
                user.ChangeClient(allClients[id2-1]);
            }
            else Console.WriteLine("Wrong input");
            break;
        default:
            Console.WriteLine("Wrong input");
            break;
    }
}