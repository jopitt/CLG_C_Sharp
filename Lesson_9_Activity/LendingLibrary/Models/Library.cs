using System;
using System.Collections.Generic;

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

        public Library(string name)
        {
            Name = name;
        }

        public Library()
        {
            TextBooks = new List<TextBook>();
            Albums = new List<Album>();
            AudioBooks = new List<AudioBook>();
            Borrowers = new List<Borrower>();
        }
        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        public void ListNovels()
        {
            Console.WriteLine($"{Name} - List of Novels:");
            foreach (var novel in Novels)
            {
                Console.WriteLine($"\t {novel.Title} by {novel.Author}, {novel.PublicationYear}, {novel.Genre}");
            }
        }

        public void SetNovels()
        {
            var novel1 = new Novel ("The Cat in the Hat", "Dr Suess", 1957, "Children");
            var novel2 = new Novel ("Oh, the Places You'll Go", "Dr Suess", 1990, "Children");
            var novel3 = new Novel ("Emma", "Jane Austen", 1815, "Literature");

            AddNovel(novel1);
            AddNovel(novel2);
            AddNovel(novel3);
            ListNovels();
        }

        public void AddTextBook(TextBook textBook)
        {
            TextBooks.Add(textBook);
        }

        public void ListTextBooks()
        {
            Console.WriteLine($"{Name} - List of Text Books:");
            foreach (var textBook in TextBooks)
            {
                Console.WriteLine($"\t {textBook.Title} by {textBook.Author}, {textBook.PublicationYear}, {textBook.Subject}");
            }
        }

        public void SetTextbooks()
        {
             var textbook1 = new TextBook ("Fundamentals of Chemistry", "Kate Rowan", 2018, "Chemistry");
            var textbook2 = new TextBook ("Neurosurgical Care of the Elderley", "Warren R. Selman and Edward Benzel", 1999, "Medicine");
            var textbook3 = new TextBook ("The New Lawyer", "Nickolas James and Rachael Field", 2019, "Law");

            AddTextBook(textbook1);
            AddTextBook(textbook2);
            AddTextBook(textbook3);

            ListTextBooks();
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        public void ListAlbums()
        {
            Console.WriteLine($"{Name} - List of Albums:");
            foreach (var album in Albums)
            {
                Console.WriteLine($"\t {album.Title} by {album.Artist}, {album.PublicationYear}, {album.NumberOfTracks} tracks");
            }
        }

        public void SetAlbums()
        {
            var album1 = new Album ("Abbey Road", "The Beatles", 10, 1969);
            var album2 = new Album ("Back to Black", "Amy Winehouse", 11, 2006);

            AddAlbum(album1);
            AddAlbum(album2);

            ListAlbums();
        }
        public void AddAudioBook(AudioBook audioBook)
        {
            AudioBooks.Add(audioBook);
        }

        public void ListAudioBooks()
        {
            Console.WriteLine($"{Name} - List of Audio Books:");
            foreach (var audioBook in AudioBooks)
            {
                Console.WriteLine($"\t {audioBook.Title} by {audioBook.Author}, {audioBook.PublicationYear}, {audioBook.NumberOfTracks} tracks");
            }
        }

        public void SetAudioBooks()
        {
            var audioBook1 = new AudioBook ("Dune", "Frank Herbert", 21, 2007);
            var audioBook2 = new AudioBook ("The Eye of the World: Book One of the Wheel of Time", "Robert Jordan", 50, 2004);

            AddAudioBook(audioBook1);
            AddAudioBook(audioBook2);

            ListAudioBooks();
        }

        public void AddBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void ListBorrowers()
        {
            Console.WriteLine($"{Name} - List of Borrowers:");
            foreach (var borrower in Borrowers)
            {
                Console.WriteLine($"\t {borrower.MemberName}, {borrower.MemberNumber}");
            }
        }

        public void SetBorrowers()
        {
            var borrower1 = new Borrower ("Jane Lacey", 1111);
            var borrower2 = new Borrower ("Lilith Jones", 1112);
            var borrower3 = new Borrower ("Casey Bourne", 1113);

            AddBorrower(borrower1);
            AddBorrower(borrower2);
            AddBorrower(borrower3);

            ListBorrowers();
        }

        public void AddLibraryItems()
        {
            while(true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose from the following items to add to the library:");
                Console.WriteLine("novel = add a novel");
                Console.WriteLine("textbook = add a textbook");
                Console.WriteLine("album = add an album");
                Console.WriteLine("audiobook = add an audio book");
                Console.WriteLine("X = Exit");
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "x")
                {
                    break;
                }

                switch(userInput.ToLower())
                {
                    case "novel":

                        Console.WriteLine("Enter title:");
                        var title = Console.ReadLine();
                        Console.WriteLine("Enter author:");
                        var author = Console.ReadLine();
                        Console.WriteLine("Enter the publication year:");
                        var publicationYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter genre:");
                        var genre = Console.ReadLine();
                        var newNovel = new Novel (title, author, publicationYear, genre);
                        AddNovel(newNovel);
                                
                        Console.WriteLine($"{newNovel.Title} by {newNovel.Author} has been added to the Library.");
                        Console.WriteLine();
                        ListNovels();
                        break;

                    case "textbook":

                        Console.WriteLine("Enter title:");
                        var textbookTitle = Console.ReadLine();
                        Console.WriteLine("Enter author:");
                        var textbookAuthor = Console.ReadLine();
                        Console.WriteLine("Enter the publication year:");
                        var textbookPublicationYear = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter subject:");
                        var subject = Console.ReadLine();
                        var newTextbook = new TextBook (title = textbookTitle, author = textbookAuthor, publicationYear = textbookPublicationYear, subject);
                        AddTextBook(newTextbook);
                                
                        Console.WriteLine($"{newTextbook.Title} by {newTextbook.Author} has been added to the Library.");
                        Console.WriteLine();
                        ListTextBooks();
                        break;

                    case "album":

                        Console.WriteLine("Enter title:");
                        var albumTitle = Console.ReadLine();
                        Console.WriteLine("Enter artist:");
                        var artist = Console.ReadLine();
                        Console.WriteLine("Enter number of tracks:");
                        var numberOfTracks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the publication year:");
                        var albumPublicationYear = int.Parse(Console.ReadLine());
                        var newAlbum = new Album (title = albumTitle, artist, numberOfTracks, publicationYear = albumPublicationYear);
                        AddAlbum(newAlbum);
                                
                        Console.WriteLine($"{newAlbum.Title} by {newAlbum.Artist} has been added to the Library.");
                        Console.WriteLine();
                        ListAlbums();
                        break;

                    case "audiobook":

                        Console.WriteLine("Enter title:");
                        var audiobookTitle = Console.ReadLine();
                        Console.WriteLine("Enter author:");
                        var audiobookAuthor = Console.ReadLine();
                        Console.WriteLine("Enter number of tracks:");
                        var audiobookNumberOfTracks = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the publication year:");
                        var audiobookPublicationYear = int.Parse(Console.ReadLine());
                        var newAudiobook = new AudioBook (title = audiobookTitle, author = audiobookAuthor, numberOfTracks = audiobookNumberOfTracks, publicationYear = audiobookPublicationYear);
                        AddAudioBook(newAudiobook);
                                
                        Console.WriteLine($"{newAudiobook.Title} by {newAudiobook.Author} has been added to the Library.");
                        Console.WriteLine();
                        ListAudioBooks();
                        break;

                    default:
                    Console.WriteLine("I didn't recognise that command.");
                    break;
                    
                }

            }
        }

    }
}