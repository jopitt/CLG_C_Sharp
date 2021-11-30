namespace LendingLibrary.Models
{
    public class Album : CD
    {
        public string Artist { get; set; }

        public Album(string title, string artist, int numberOfTracks, int publicationYear)
        {
            Title = title;
            Artist = artist;
            NumberOfTracks = numberOfTracks;
            PublicationYear = publicationYear;
        }
    }
    
}