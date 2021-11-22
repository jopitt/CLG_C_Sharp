using System;
using System.Collections.Generic;

namespace Lesson_7_Activity
{
    class Program
    {
        static void Main(string[] args)
        {

            var books = ListBooks();
            var members = ListMembers();

            Console.WriteLine("Welcome to the Book Club!");
            
            WaitForUserInput(books, members);

        }

        static List<Book> ListBooks()
	    {   
            var book1 = new Book
            {
                title = "To Kill a Mockingbird",
                author = "Harper Lee"
            };

            var book2 = new Book
            {
                title = "1984",
                author = "George Orwell"
            };

            var book3 = new Book
            {
                title = "The Lord of the Rings",
                author = "J.R.R. Tolkien"
            };

            var book4 = new Book
            {
                title = "The Catcher in the Rye",
                author = "J.D. Salinger"
            };

            var book5 = new Book
            {
                title = "The Lion, the Witch and the Wardrobe (Chronicles of Narnia, # 1)",
                author = "C.S. Lewis"
            };

            var books = new List<Book> { book1, book2, book3, book4, book5 };

            return books;
        }

        static List<Member> ListMembers()
        {
            var member1 = new Member
            {
                firstName = "Audrey",
                lastName = "Bowler",
                favouriteBook = ListBooks().Find(x => x.title == "To Kill a Mockingbird"),
                readingList = new List<Book>
                {
                    new Book() {title = "The Lion, the Witch and the Wardrobe (Chronicles of Narnia, # 1)", author = "C.S. Lewis"},
                    new Book () {title = "The Catcher in the Rye", author = "J.D. Salinger"}
                }										   
            };

            var member2 = new Member
            {
                firstName = "Daisy",
                lastName = "Flower",
                favouriteBook = ListBooks().Find(x => x.title == "The Catcher in the Rye"),
                readingList = new List<Book>
                {
                    new Book() {title = "The Lion, the Witch and the Wardrobe (Chronicles of Narnia, # 1)", author = "C.S. Lewis"},
                    new Book () {title = "The Lord of the Rings", author = "J.R.R. Tolkien"}
                }
            };

            var member3 = new Member
            {
                firstName = "Meredith",
                lastName = "Mason",
                favouriteBook = ListBooks().Find(x => x.title == "The Lion, the Witch and the Wardrobe (Chronicles of Narnia, # 1)"),
                readingList = new List<Book>
                {
                    new Book() {title = "1984", author = "George Orwell"},
                    new Book () {title = "The Catcher in the Rye", author = "J.D. Salinger"}
                }
            };

            var members = new List<Member> { member1, member2, member3 };

            return members;
        }
	
        static void WaitForUserInput(List<Book> books, List<Member> members)
        {		
            while (true)
            {
                GiveInstructions();

                var userInput = Console.ReadLine().ToLower();
                // exit the code if a user inputs X
                if (userInput == "x")
                {
                    break;
                }

                RespondToUserCommand(userInput, books, members);
            }
        }
	
        static void GiveInstructions()
        {
            Console.WriteLine();
            Console.WriteLine("What would you like to see or do?");
            Console.WriteLine("Books = See a list of books recommended by the book club");
            Console.WriteLine("Members = See a list of book club members");
            Console.WriteLine("MemberFav = See a list of members' favourite books");
            Console.WriteLine("MemberReadList = See which books are on members' reading lists");
            Console.WriteLine("AddMember = Add a new member to the book club");
            Console.WriteLine("AddBook = Add a book to the list of books recommended by the book club");
            Console.WriteLine("X = Exit");
        }
        
        static void RespondToUserCommand(string userInput, List<Book> books, List<Member> members)
        {
            switch (userInput.ToLower())
            {
                case "books":
                    Console.WriteLine("Here is a list of books recommended by the book club:");
                    foreach (var book in books)
                    {
                        book.ListBookDetails();
                    }
                    Console.WriteLine();					
                    break;

                case "members":
                    Console.WriteLine("List of members:");
                    foreach (var member in members)
                    {
                        member.ListMemberDetails();
                    }
                    Console.WriteLine();
                    break;

                case "memberfav":
                    foreach(var member in members)
                    {
                        Console.WriteLine($"{member.firstName}'s favourite book:");
                        Console.WriteLine($"\t {member.favouriteBook.title} by {member.favouriteBook.author}");
                        Console.WriteLine();
                    }
                    break;

                case "memberreadlist":
                    foreach(var member in members)
                    {
                        Console.WriteLine($"Books on {member.firstName}'s reading list:");
                        foreach (var book in member.readingList)
                        {
                            Console.WriteLine($"\t {book.title}, {book.author}");
                        }
                        Console.WriteLine();
                    }
                    break;

                case "addmember":				
                    Console.WriteLine("Enter person's first name:");
                    var firstName = Console.ReadLine();
                    
                    Console.WriteLine("Enter person's last name:");
                    var lastName = Console.ReadLine();
                    
                    var newMember = new Member{firstName = firstName, lastName = lastName, favouriteBook = new Book(), readingList = new List<Book>()};
                    members.Add(newMember);
                    
                    Console.WriteLine($"{firstName} {lastName} has been added to the book club.");
                    
                    break;
                    
                case "addbook":
                    Console.WriteLine("Enter title:");
                    var title = Console.ReadLine();
                    
                    Console.WriteLine("Enter author:");
                    var author = Console.ReadLine();
                    
                    var newBook = new Book{title = title, author = author};
                    books.Add(newBook);
                    
                    Console.WriteLine($"{newBook.title} by {newBook.author} has been added to the book list.");

                    break;

                default:
                    Console.WriteLine("I didn't recognise that command.");
                    break;
                }
        }
    }
    public class Book
    {
        public string title;
        public string author;
		
        public void ListBookDetails()
        {
            Console.WriteLine($"\t {title} by {author}");
        }
    }
    public class Member
    {
        public string firstName;
        public string lastName;
        public Book favouriteBook;
        public List<Book> readingList;
		
		public void ListMemberDetails()
		{
			Console.WriteLine($"\t {firstName} {lastName}");
		}

	}
    
}
