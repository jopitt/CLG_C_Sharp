namespace LendingLibrary.Models
{
    public abstract class Media : Library
    {
        public string Title  { get; set; }
        public int PublicationYear { get; set; }

    }
}