using LibraryManagementSystem.Lib.Services;
using LibraryManagementSystem.Lib.Utils;

namespace LibraryManagementSystem.Lib
{
    public class Menu
    {
        private Library Library { get; set; }
        private Commandhandler handler { get; set; }
        public Menu(List<Book> books, List<LoanRecord> loanRecords, List<Borrower> borrowers)
        {
            Library = new Library(books, loanRecords, borrowers);
            handler = new(Library);
        }

        public void Start()
        {
            Console.Clear();
            Console.WriteLine("1. Login\n2. SignUp\n3. Exit");
            int index = GetCommand.Command(3);
            Handlestart(index);
        }

        private void Handlestart(int index)
        {
            switch (index)
            {
                case 1:
                    LoginMenu();
                    break;

                case 2:
                    SignUp();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("fail");
                    break;
            }
        }

        private void LoginMenu()
        {
            Console.Clear();
            Console.WriteLine("Login");
            while (true)
            {
                Console.WriteLine("Please enter valid username");
                string username = Console.ReadLine()!;

                if (username == "")
                {
                    Console.WriteLine("please enter a username.");
                    continue;
                }

                if (Library.IsBorrower(username))
                {
                    break;
                }
                Console.WriteLine($"There is no user {username}.");
            }
            MenuScreen();
        }

        private void MenuScreen()
        {
            Console.Clear();
            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Borrow a book.\n2. Return a book.\n3. View borrowed books.\n4. borrow History.\n5. LogOut.");
            int index = GetCommand.Command(5);
            if (index == 5)
            {
                LogOut();
            }

            handler.HandleMainCommands(index);
        }

        private void SignUp()
        {
            Console.Clear();
            string name = GetInput.Getusername();
            string contactinfo = GetInput.GetEmail();

            Library.AddNewBorrower(name, contactinfo);
            LoginMenu();
        }

        private void LogOut()
        {
            string input;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Are you sure you wanna LogOut (y/n)?");
                input = Console.ReadLine()!;
                if (input == "")
                {
                    Console.WriteLine("Please enter a answer.");
                    continue;
                }

                if (input.ToLower().Equals("y") || input.Equals("n"))
                {
                    break;
                }
                Console.WriteLine("Invalid input.");
            }

            if (input.ToLower().Equals("y"))
            {
                Start();
            }
            MenuScreen();
        }

        
    }
}