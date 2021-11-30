namespace LendingLibrary.Models
{
    public class TextBook : Book
    {
        public string Subject { get; set; }

        public TextBook(string title, string author, int publicationYear, string subject)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Subject = subject;
        }



    }
    
}