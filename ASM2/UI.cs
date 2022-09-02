using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class UI
    {
        public static int InitialMenu()
        { 
            Console.WriteLine("--- MUSIC MANAGEMENT SYSTEM ---");
            Console.WriteLine("1. Display all existing songs");
            Console.WriteLine("2. Search music");
            Console.WriteLine("3. Add music");
            Console.WriteLine("4. Remove music");
            Console.WriteLine("5. Update music");
            Console.WriteLine("6. Exit");
            Console.Write("Choose your option: ");
            return int.Parse(Console.ReadLine());
        }

        public static int SetId()
        {
            Console.Write("Enter ID of the song: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        public static string SetName()
        {
            Console.Write("Enter the name of the song: ");
            string name = Console.ReadLine();
            return name;
        }

        public static string SetAuthor()
        {
            Console.Write("Enter the author of the song: ");
            string author = Console.ReadLine();
            return author;
        }

        public static string SetAlbum()
        {
            Console.Write("Enter the album name of the song: ");
            string album = Console.ReadLine();
            return album;
        }

        public static double SetPrice()
        {
            Console.Write("Enter the price of the song: ");
            double price = double.Parse(Console.ReadLine());
            return price;
        }

    }
}
