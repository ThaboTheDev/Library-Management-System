namespace LibraryManagementSystem.Lib.Utils
{
    static public class GetInput
    {
        static public string Getusername()
        {
            while (true)
            {
                Console.WriteLine("Please enter username: ");
                string name = Console.ReadLine()!;
                if (name.Equals(""))
                {
                    Console.WriteLine("please enter a username.");
                    continue;
                }
                return name;
            }
        }

        static public string GetEmail()
        {
            while (true)
            {
                Console.WriteLine("Please enter a email address: ");
                string contactinfo = Console.ReadLine()!;
                if (contactinfo.Equals(""))
                {
                    Console.WriteLine("Please enter a email address.");
                    continue;
                }

                if (!contactinfo.ToList().Contains('@'))
                {
                    Console.WriteLine("Please enter a valid email address");
                    continue;
                }
                return contactinfo;
            }
        }
    }
}