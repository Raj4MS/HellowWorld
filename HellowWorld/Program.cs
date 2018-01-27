using System.IO;

namespace HellowWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            File.WriteAllText("D:\\hello.txt", "Raj kumar");
        }
    }
}
