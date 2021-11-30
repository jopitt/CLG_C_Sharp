using System;
using System.Collections.Generic;
using LendingLibrary.Models;

namespace LendingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {  
 
            var library = new Library ("Brisbane Library");

            var novel1 = new Novel ("The Cat in the Hat", "Dr Suess", 1957, "Children");
            var novel2 = new Novel ("Oh, the Places You'll Go", "Dr Suess", 1990, "Children");
            var novel3 = new Novel ("Emma", "Jane Austen", 1815, "Literature");

            library.AddNovel(novel1);
            library.AddNovel(novel2);
            library.AddNovel(novel3);

            Console.WriteLine($"{library.Name} - List of Novels:");
            foreach (var novel in library.Novels)
            {
                Console.WriteLine($"\t {novel.Title}");
            }

            var textbook1 = new TextBook ("Fundamentals of Chemistry", "Kate Rowan", 2018, "Chemistry");
            var textbook2 = new TextBook ("Neurosurgical Care of the Elderley", "Warren R. Selman and Edward Benzel", 1999, "Medicine");
            var textbook3 = new TextBook ("The New Lawyer", "Nickolas James and Rachael Field", 2019, "Law");

            library.AddTextBook(textbook1);
            library.AddTextBook(textbook2);
            library.AddTextBook(textbook3);

            Console.WriteLine($"{library.Name} - List of Text Books:");
            foreach (var textBook in library.TextBooks)
            {
                Console.WriteLine($"\t {textBook.Title}");
            }

            var album1 = new Album ("Abbey Road", "The Beatles", 10, 1969);
            var album2 = new Album ("Back to Black", "Amy Winehouse", 11, 2006);

            library.AddAlbum(album1);
            library.AddAlbum(album2);

            Console.WriteLine($"{library.Name} - List of Albums:");
            foreach (var album in library.Albums)
            {
                Console.WriteLine($"\t {album.Title}");
            }

            var audioBook1 = new AudioBook ("Dune", "Frank Herbert", 21, 2007);
            var audioBook2 = new AudioBook ("The Eye of the World: Book One of the Wheel of Time", "Robert Jordan", 50, 2004);

            library.AddAudioBook(audioBook1);
            library.AddAudioBook(audioBook2);

            Console.WriteLine($"{library.Name} - List of Audio Books:");
            foreach (var audioBook in library.AudioBooks)
            {
                Console.WriteLine($"\t {audioBook.Title}");
            }

        }
        

    }
}
