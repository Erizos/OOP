using System;
using System.Linq;
using System.Reflection;

namespace ASM2
{
    public interface ISong
    {
        string DisplayDetail();
    }
    public class Song : ISong
    {
        private string name = "Default song";
        private int id;
        private string author = "Default author";
        private string album = "Default album";
        private double price = 9.99;

        public Song(int id, string name, string author, string album, double price)
        {
            Id = id;
            Name = name;
            Author = author;
            Album = album;
            Price = price;
        }

        public int Id { get => id; set => id = value; }

        public string Name
        {
            get => name;
            set
            {
                if(value == null)
                {
                    throw new ArgumentException("The name of the song must not be null");
                }
                name = value;
            }
        }

        public string Author
        {
            get => author;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name of author must be filled");
                }
                author = value;
            }
        }

        public string Album { get => album; set => album = value; }

        public double Price { 
            get => price;
            set {
            if (value < 0)
                {
                    throw new ArgumentException("The price must be valid");
                }
            price = value;
            }
        }
        public string DisplayDetail()
        {
            return $"{GetType().Name} {Id} | Name : {Name} | Author : {Author} | Album : {Album} | Price: {Price}\n";
        }

    }
}