namespace LibraryManagementSystem.Lib
{
    public class Borrower(long Id, string Name, string ContactInfo, List<Book> BorrowedBooks)
    {
        public long Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string ContactInfo { get; set; } = ContactInfo;
        public List<Book> BorrowedBooks { get; set; } = BorrowedBooks;

        public bool AddBorrowedBook(Book Book)
        {
            if (!IsBorrowedByUser(Book))
            {
                BorrowedBooks.Add(Book);
                return true;
            }
            return false;
        }

        public bool ReturnBorrowedBook(Book Book)
        {
            if (IsBorrowedByUser(Book))
            {
                BorrowedBooks.Remove(Book);
                return true;
            }
            return false;
        }

        public void DisplayBorrowedBooks()
        {
            Console.WriteLine("=============================");
            Console.WriteLine("Borrowed Books");
            Console.WriteLine("=============================");
            foreach (Book book in BorrowedBooks)
            {
                Console.WriteLine(book.ToString());
                Console.WriteLine();
            }
            
            do
            {
                Console.WriteLine("Press enter to exit.");
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter);
        }

        private bool IsBorrowedByUser(Book Book)
        {
            foreach (Book i in BorrowedBooks)
            {
                if (i.Equals(Book))
                {
                    return true;
                }
            }
            return false;
        }
    }
}