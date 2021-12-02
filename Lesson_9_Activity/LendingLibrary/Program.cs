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

            library.ListNovels();

            var textbook1 = new TextBook ("Fundamentals of Chemistry", "Kate Rowan", 2018, "Chemistry");
            var textbook2 = new TextBook ("Neurosurgical Care of the Elderley", "Warren R. Selman and Edward Benzel", 1999, "Medicine");
            var textbook3 = new TextBook ("The New Lawyer", "Nickolas James and Rachael Field", 2019, "Law");

            library.AddTextBook(textbook1);
            library.AddTextBook(textbook2);
            library.AddTextBook(textbook3);

            library.ListTextBooks();

            var album1 = new Album ("Abbey Road", "The Beatles", 10, 1969);
            var album2 = new Album ("Back to Black", "Amy Winehouse", 11, 2006);

            library.AddAlbum(album1);
            library.AddAlbum(album2);

            library.ListAlbums();

            var audioBook1 = new AudioBook ("Dune", "Frank Herbert", 21, 2007);
            var audioBook2 = new AudioBook ("The Eye of the World: Book One of the Wheel of Time", "Robert Jordan", 50, 2004);

            library.AddAudioBook(audioBook1);
            library.AddAudioBook(audioBook2);

            library.ListAudioBooks();

            var borrower1 = new Borrower ("Jane Lacey", 1111);
            var borrower2 = new Borrower ("Lilith Jones", 1112);
            var borrower3 = new Borrower ("Casey Bourne", 1113);

            library.AddBorrower(borrower1);
            library.AddBorrower(borrower2);
            library.AddBorrower(borrower3);

            library.ListBorrowers();

            borrower1.AddNovel(novel1);
            borrower1.AddNovel(novel3);
            borrower1.AddTextBook(textbook2);
            borrower1.AddAlbum(album1);
            borrower1.AddAudioBook(audioBook2);

            Console.WriteLine($"For member number {borrower1.MemberNumber} - List of items on loan:");
            foreach (var novel in borrower1.Novels)
            {
                Console.WriteLine($"\t {novel.Title}");
            }
            foreach (var textbook in borrower1.TextBooks)
            {
                Console.WriteLine($"\t {textbook.Title}");
            }
            foreach (var album in borrower1.Albums)
            {
                Console.WriteLine($"\t {album.Title}");
            }
            foreach (var audiobook in borrower1.AudioBooks)
            {
                Console.WriteLine($"\t {audiobook.Title}");
            }

            library.AddLibraryItems();

            
            

        }
        

    }
}
