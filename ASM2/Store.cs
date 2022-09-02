using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Store
    {
        private List<Song> songs = new List<Song>();

        public Store()
        {

        }

        public string DisplayDetail()
        {
            string result = "";
            foreach(var s in songs)
            {
                result += s.DisplayDetail();
            }
            if (result == "")
            {
                Console.WriteLine("The list is empty!");
                return result;
            }
            return result;
        }
        public bool CheckId(int id)
        {
            Song checkingSong = songs.FirstOrDefault(s => s.Id.Equals(id));
            if (checkingSong != null) return true;
            return false;
        }
        public void AddMusic(Song song)
        {
            if (CheckId(song.Id)) {
                Console.WriteLine("ID is existed!");
            }
            else songs.Add(song);
        }
        public void UpdateMusic(int id, string name, string author, string album, double price)
        {
            Song updatedSong = songs.FirstOrDefault(s => s.Id.Equals(id));
            if (updatedSong != null)
            {
                updatedSong.Name = name;
                updatedSong.Author = author;
                updatedSong.Album = album;
                updatedSong.Author = author;
                updatedSong.Price = price;
                Console.WriteLine("Updated successfully!");
            }
            else Console.WriteLine("The id of the song you provided does not exist!");
        }
        public void DeleteMusicById(int id)
        {
            Song deletedSong = songs.FirstOrDefault(s => s.Id.Equals(id));
            if (deletedSong != null)
            {
                songs.Remove(deletedSong);
                Console.WriteLine("Deleted successfully!\n");
            }
            else Console.WriteLine("An error has occurred!\n");
        }

        public string Search(string name)
        {
            string result = "";
            foreach(var found in songs.Where(s => s.Name.Contains(name)))
            {
                result += found.DisplayDetail();
            }
            if (result == "") {
                Console.WriteLine("There is no song with that name.");
                return result;
            }else return result;
        }

    }
}
