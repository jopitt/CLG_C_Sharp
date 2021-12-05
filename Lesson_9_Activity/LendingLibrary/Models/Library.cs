using System;
using System.Collections.Generic;
using System.Globalization;

namespace LendingLibrary.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Novel> Novels = new List<Novel>();
        public List<TextBook> TextBooks = new List<TextBook>();
        public List<Album> Albums = new List<Album>();
        public List<AudioBook> AudioBooks = new List<AudioBook>();
        internal List<Borrower> Borrowers = new List<Borrower>();
        TextInfo titleCase = new CultureInfo("en-US",false).TextInfo;


        public Library(string name)
        {
            Name = name;
        }

        public void SetNovels() 
        {
            Novels.Add(new Novel ("The Cat in the Hat", "Dr Suess", 1957, "Children"));
            Novels.Add(new Novel ("Oh, the Places You'll Go", "Dr Suess", 1990, "Children"));
            Novels.Add(new Novel ("Emma", "Jane Austen", 1815, "Literature"));

            ListNovels();
        }

        public void ListNovels()
        {
            Console.WriteLine($"{Name} - List of Novels:");
            foreach (var novel in Novels)
            {
                Console.WriteLine($"\t {novel.Title} by {novel.Author}, {novel.PublicationYear}, {novel.Genre}");
            }
        }

        public void SetTextbooks()
        {
            TextBooks.Add (new TextBook ("Fundamentals of Chemistry", "Kate Rowan", 2018, "Chemistry"));
            TextBooks.Add (new TextBook ("Neurosurgical Care of the Elderley", "Warren R. Selman and Edward Benzel", 1999, "Medicine"));
            TextBooks.Add (new TextBook ("The New Lawyer", "Nickolas James and Rachael Field", 2019, "Law"));

            ListTextBooks();
        }
        
        public void ListTextBooks()
        {
            Console.WriteLine($"{Name} - List of Text Books:");
            foreach (var textBook in TextBooks)
            {
                Console.WriteLine($"\t {textBook.Title} by {textBook.Author}, {textBook.PublicationYear}, {textBook.Subject}");
            }
        }

        public void SetAlbums()
        {
            Albums.Add (new Album ("Abbey Road", "The Beatles", 10, 1969));
            Albums.Add (new Album ("Back to Black", "Amy Winehouse", 11, 2006));

            ListAlbums();
        }

        public void ListAlbums()
        {
            Console.WriteLine($"{Name} - List of Albums:");
            foreach (var album in Albums)
            {
                Console.WriteLine($"\t {album.Title} by {album.Artist}, {album.PublicationYear}, {album.NumberOfTracks} tracks");
            }
        }

        public void SetAudioBooks()
        {
            AudioBooks.Add (new AudioBook ("Dune", "Frank Herbert", 21, 2007));
            AudioBooks.Add (new AudioBook ("The Eye of the World: Book One of the Wheel of Time", "Robert Jordan", 50, 2004));

            ListAudioBooks();
        }
        
        public void ListAudioBooks()
        {
            Console.WriteLine($"{Name} - List of Audio Books:");
            foreach (var audioBook in AudioBooks)
            {
                Console.WriteLine($"\t {audioBook.Title} by {audioBook.Author}, {audioBook.PublicationYear}, {audioBook.NumberOfTracks} tracks");
            }
        }

        public void SetBorrowers()
        {
            Borrowers.Add (new Borrower ("Jane Lacey", 1111));
            Borrowers.Add (new Borrower ("Lilith Jones", 1112));
            Borrowers.Add (new Borrower ("Casey Bourne", 1113));

            ListBorrowers();
        }

        public void ListBorrowers()
        {
            Console.WriteLine($"{Name} - List of Borrowers:");
            foreach (var borrower in Borrowers)
            {
                Console.WriteLine($"\t {borrower.MemberName}, {borrower.MemberNumber}");
            }
        }

        
        public void AddLibraryItems()
        {
            while(true)
            {
                GiveInstructions();
                
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "x")
                {
                    break;
                }

                switch(userInput.ToLower())
                {
                    case "novel":
                        UserInputNovel();
                        break;

                    case "textbook":
                        UserInputTextbook();
                        break;

                    case "album":
                        UserInputAlbum();
                        break;

                    case "audiobook":
                        UserInputAudioBook();
                        break;

                    default:
                        Console.WriteLine("I didn't recognise that command.");
                        break;
                }
            }
        }

        public void GiveInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("Choose from the following items to add to the library:");
            Console.WriteLine("novel = add a novel");
            Console.WriteLine("textbook = add a textbook");
            Console.WriteLine("album = add an album");
            Console.WriteLine("audiobook = add an audio book");
            Console.WriteLine("X = Exit");
        }
        
        public void UserInputNovel()
        {
            Console.WriteLine("Enter title:");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter author:");
            var author = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the publication year:");
            var publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter genre:");
            var genre = Console.ReadLine().ToLower();
            Novels.Add (new Novel (titleCase.ToTitleCase(title), titleCase.ToTitleCase(author), publicationYear, titleCase.ToTitleCase(genre)));
                    
            Console.WriteLine($"{titleCase.ToTitleCase(title)} by {titleCase.ToTitleCase(author)} has been added to the Library.");
            Console.WriteLine();
            ListNovels();
        }

        public void UserInputTextbook()
        {
            Console.WriteLine("Enter title:");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter author:");
            var author = Console.ReadLine().ToLower();
            Console.WriteLine("Enter the publication year:");
            var publicationYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter subject:");
            var subject = Console.ReadLine().ToLower();
            TextBooks.Add (new TextBook (titleCase.ToTitleCase(title), titleCase.ToTitleCase(author), publicationYear, titleCase.ToTitleCase(subject)));
                    
            Console.WriteLine($"{titleCase.ToTitleCase(title)} by {titleCase.ToTitleCase(author)} has been added to the Library.");
            Console.WriteLine();
            ListTextBooks();
        }

        public void UserInputAlbum()
        {
            Console.WriteLine("Enter title:");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter artist:");
            var artist = Console.ReadLine().ToLower();
            Console.WriteLine("Enter number of tracks:");
            var numberOfTracks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the publication year:");
            var publicationYear = int.Parse(Console.ReadLine());
            Albums.Add (new Album (titleCase.ToTitleCase(title), titleCase.ToTitleCase(artist), numberOfTracks, publicationYear));                        
                    
            Console.WriteLine($"{titleCase.ToTitleCase(title)} by {titleCase.ToTitleCase(artist)} has been added to the Library.");
            Console.WriteLine();
            ListAlbums();
        }

        public void UserInputAudioBook()
        {
            Console.WriteLine("Enter title:");
            var title = Console.ReadLine().ToLower();
            Console.WriteLine("Enter author:");
            var author = Console.ReadLine().ToLower();
            Console.WriteLine("Enter number of tracks:");
            var numberOfTracks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the publication year:");
            var publicationYear = int.Parse(Console.ReadLine());
            Albums.Add (new Album (titleCase.ToTitleCase(title), titleCase.ToTitleCase(author), numberOfTracks, publicationYear));                        
                    
            Console.WriteLine($"{titleCase.ToTitleCase(title)} by {titleCase.ToTitleCase(author)} has been added to the Library.");
            Console.WriteLine();
            ListAlbums();
        }
    }
}