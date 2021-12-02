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
            Novels = new List<Novel>();
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
                Console.WriteLine($"\t {novel.Title}");
            }
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
                Console.WriteLine($"\t {textBook.Title}");
            }
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
                Console.WriteLine($"\t {album.Title}");
            }
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
                Console.WriteLine($"\t {audioBook.Title}");
            }
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
                }

            }
        }

    }
}