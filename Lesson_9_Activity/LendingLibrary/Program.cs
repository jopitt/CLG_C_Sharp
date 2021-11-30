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

            var novel1 = new Novel("The Cat in the Hat", "Dr Suess", 1957, "Children");
            
            var novel2 = new Novel ("Oh, the Places You'll Go", "Dr Suess", 1990, "Children");

            var novel3 = new Novel ("Emma", "Jane Austen", 1815, "Literature");

            library.AddNovel(novel1);
            library.AddNovel(novel2);
            library.AddNovel(novel3);

            Console.WriteLine(library.Name);
            foreach (var novel in library.Novels)
            {
                Console.WriteLine(novel.Title);
            }



        }
        

    }
}
