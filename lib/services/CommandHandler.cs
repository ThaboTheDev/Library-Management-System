
namespace LibraryManagementSystem.Lib.Services
{
    public class Commandhandler(Library library1)
    {
        public Library library = library1;

        public void HandleMainCommands(int index)
        {
            switch (index)
            {
                case 1:
                    library.DisplayBooks();
                    break;

                default:
                    Console.WriteLine("fail");
                    break;
            }
        }
    }
}