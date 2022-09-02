namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddMusic(new Song(1, "Joicelyn Flores", "XXXTENTACION", "17", 9.99));
            store.AddMusic(new Song(2, "Blackout", "Azari", "None", 5.99));
            store.AddMusic(new Song(3, "STAR PLAYER", "4s4ski", "None", 6.99));
            store.AddMusic(new Song(4, "ATTENTION", "Joji", "BALLADS 1", 6.99));
            
            while(true)
            {
                int input = UI.InitialMenu();
                
                switch (input)
                {
                    case 1: //display all songs
                        Console.WriteLine("List of existing music: ");
                        Console.WriteLine(store.DisplayDetail());
                        break;
                    case 2: //search
                        Console.Write("Please enter the name of the song you want to search: ");
                        string name = Console.ReadLine();
                        if (name == "")
                        {
                            Console.WriteLine("The name of the song must be declared!\n");
                        }
                        else Console.WriteLine(store.Search(name));
                        break;
                    case 3: //add a new song
                        store.AddMusic(new Song(
                            UI.SetId(),
                            UI.SetName(),
                            UI.SetAuthor(),
                            UI.SetAlbum(),
                            UI.SetPrice()));
                        break;
                    case 4: //remove a song
                        Console.Write("Please enter the id of the song you want to remove: ");
                        int id = int.Parse(Console.ReadLine());
                        store.DeleteMusicById(id);
                        break;
                    case 5: //update a song
                        Console.Write("Please enter the information of the song you want to update: \n");
                        store.UpdateMusic(UI.SetId(), UI.SetName(), UI.SetAuthor(), UI.SetAlbum(), UI.SetPrice());
                        break;
                    case 6: //exit
                        Environment.Exit(0);
                        return;
                    default:
                        Console.WriteLine("This option does not available!\n");
                        break;
                }
            }
        }
    }
}

