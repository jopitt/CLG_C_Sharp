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
        }
        public void AddNovel(Novel novel)
        {
            Novels.Add(novel);
        }

        public void AddTextBook(TextBook textBook)
        {
            TextBooks.Add(textBook);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }
        public void AddAudioBook(AudioBook audioBook)
        {
            AudioBooks.Add(audioBook);
        }
    }
}