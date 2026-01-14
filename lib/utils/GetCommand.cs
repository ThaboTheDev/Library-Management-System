namespace LibraryManagementSystem.Lib.Utils
{

    static public class GetCommand
    {
        static public int Command(int limit)
        {
            bool flag;
            int index = 0;
            do
            {
                try
                {
                    Console.WriteLine("what would you like to do ? ");
                    string input = Console.ReadLine()!.Trim();
                    index = int.Parse(input);
                    if (index < 0 || index > limit)
                    {
                        flag = true;
                    }
                    flag = false;
                }
                catch (Exception e)
                {
                    flag = true;
                    Console.WriteLine("Error: " + e.Message);
                    Console.WriteLine("Please try again.");
                }
            } while (flag);
            return index;
        }
    }
}