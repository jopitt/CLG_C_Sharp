using System.Collections.Generic;

namespace LendingLibrary.Models
{
    public class Library
    {
        public string Name { get; set; }
        public List<Novel> Novels;
        public List<TextBook> TextBooks;
        public List<Album> Albums;
        public List<AudioBook> AudioBooks;

        public Library(string name)
        {
            Name = name;
        }

        public Library()
        {
            Novels = new List<Novel>();
        }
        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        
    }
}