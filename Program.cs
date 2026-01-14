using LibraryManagementSystem.Lib;
using LibraryManagementSystem.Lib.Services;

namespace LibraryManagementSystem
{
    public class Program{
        public static async Task Main(string[] args) {

            try
            {
                List<Book> books = await DataHandler.FetchData<List<Book>>("assets/books.json");
                List<LoanRecord> loanRecords = await DataHandler.FetchData<List<LoanRecord>>("assets/loans.json");
                List<Borrower> borrowers = await DataHandler.FetchData<List<Borrower>>("assets/borrowers.json");

                Menu menu = new(books, loanRecords, borrowers);
                menu.Start();
            } catch (Exception) {}
        }
    }
}