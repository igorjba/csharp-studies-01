using _17Exercicio05;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented (1-10)? ");
            int rentedRoomsCount = int.Parse(Console.ReadLine());

            Rent[] roomsList = new Rent[10];

            for (int i = 0; i < rentedRoomsCount; i++)
            {
                Console.WriteLine($"Rent {i + 1}:");
                Console.Write("Enter your first name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your chosen room (0-9): ");
                int roomNumber = int.Parse(Console.ReadLine());

                Student student = new Student { FirstName = name, Email = email };
                roomsList[roomNumber] = new Rent { RentId = i + 1, Student = student, RoomNumber = roomNumber };
            }

            var rentedRooms = roomsList.Where(room => room != null).OrderBy(room => room.RoomNumber);

            Console.WriteLine("\nRented rooms:");
            foreach (var room in rentedRooms)
            {
                Console.WriteLine($"Room {room.RoomNumber}: {room.Student.FirstName}, {room.Student.Email}");
            }
        }
    }
}