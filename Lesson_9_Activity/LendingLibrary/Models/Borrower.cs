namespace LendingLibrary.Models
{
    public class Borrower
    {
        internal string MemberName { get; set; }
        public int MemberNumber { get; set; }

        public Borrower(string memberName, int memberNumber)
        {
            MemberName = memberName;
            MemberNumber = memberNumber;
        }

        
    }
}