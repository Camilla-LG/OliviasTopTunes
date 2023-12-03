// See https://aka.ms/new-console-template for more information

using OliviasTopTunes;

class Program
{
    private Songs songsInstance;
    bool RunProgram = true;

    public Program()
    {
        songsInstance = new Songs("", "");
    }

    public void MainMenu()
    {
        while (RunProgram == true) {
            Console.WriteLine();
            Console.WriteLine("Velkommen til Olivias favoritter!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine(" *** Meny *** ");
            Console.WriteLine();
            Console.WriteLine("1. Vis sanger.");
            Console.WriteLine("2. Legg til ny sang.");
            Console.WriteLine("3. Slett sang.");
            Console.WriteLine("4. Exit program.");
            Console.WriteLine();

            var userChoice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (userChoice)
            {
                case '1':
                    songsInstance.DisplaySongInfo();
                    break;
                case '2':
                    AddSong();
                    break;
                case '3':
                    songsInstance.DeleteSong();
                    break;
                case '4':
                    Console.WriteLine("Bye Bye.");
                    RunProgram = false;
                    break;
                default:
                    break;
            }
        }
    }

    public void AddSong()
    {
        Console.Write("Skriv inn bandnavn: ");
        string band = Console.ReadLine();
        Console.Write("Skriv inn sangnavn: ");
        string song = Console.ReadLine();

        songsInstance.AddSong(band, song);
    }

    static void Main()
    {
        Program programInstance = new Program();
        programInstance.MainMenu();
    }
}