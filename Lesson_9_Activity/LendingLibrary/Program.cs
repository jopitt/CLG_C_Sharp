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

            library.SetNovels();

            library.SetTextbooks();

            library.SetAlbums();

            library.SetAudioBooks();

            library.SetBorrowers();

            library.AddLibraryItems();
        }
    }
}
