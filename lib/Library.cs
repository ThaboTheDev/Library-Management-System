using System.Security.Cryptography;
using System.Text.Json;
using LibraryManagementSystem.Lib.Services;
using LibraryManagementSystem.Lib.Utils;

namespace LibraryManagementSystem.Lib
{
    public class Library(List<Book> books, List<LoanRecord> loanRecords, List<Borrower> borrowers)
    {
        private List<Book> Books { get; set; } = books;
        private List<LoanRecord> Loans { get; set; } = loanRecords;
        private List<Borrower> Borrowers { get; set; } = borrowers;
        private Borrower? CurrentBorrower { get; set; }

        public void DisplayBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine("Books:");
                Console.WriteLine($"{i + 1}. {Books[i].Title}");
            }
        }

        public void BorrowBook(int userId)
        {
            Console.Clear();
            DisplayBooks();
            int index = GetCommand.Command(Books.Count);
            Book book = Books[index - 1];
            
            book.ChangeAvailability();
        }

        public bool IsBorrower(string username)
        {
            foreach (var borrower in Borrowers)
            {
                string name = borrower.Name.ToLower();
                if (name.Equals(username.ToLower()))
                {
                    CurrentBorrower = borrower;
                    return true;
                }
            }
            return false;
        }

        public void ResetBorrower()
        {
            CurrentBorrower = null;
        }

        public async void AddNewBorrower(string name, string contactinfo)
        {
            Borrowers.Add(new Borrower(GetUuid.GenerateUuid(), name, contactinfo, []));
            Borrowers = await DataHandler.SaveData("assets/borrowers.json", Borrowers);
        }
    }
}