using System.Security.Cryptography;

namespace LibraryManagementSystem.Lib.Utils
{
    public class GetUuid
    {
        public static long GenerateUuid()
        {
            byte[] bytes = new byte[sizeof(long)];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return BitConverter.ToInt64(bytes, 0);
        }
    }
}