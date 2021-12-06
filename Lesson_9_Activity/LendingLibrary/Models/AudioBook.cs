using System;

namespace LendingLibrary.Models
{
    public class AudioBook : CD
    {
        public string Author { get; set; }

        public AudioBook(string title, string author, int numberOfTracks, int publicationYear)
        {
            Title = title;
            Author = author;
            NumberOfTracks = numberOfTracks;
            PublicationYear = publicationYear;
        }

        public void DisplayAudioBooks()
        {
            Console.WriteLine($"\t {Title} by {Author}, {PublicationYear}, {NumberOfTracks} tracks");
        }
    }
    
}