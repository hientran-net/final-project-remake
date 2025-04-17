using System.Text;
using Topic2.Helper;
using Topic2.Models;

namespace Topic2;

class Program
{
    static void Main(string[] args)
    {
        // define output encoding:
        Console.OutputEncoding = Encoding.UTF8;

        do
        {
            int option;
            Console.WriteLine("1. Tạo sách.");
            Console.Write("Chọn: ");
            option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Book book = new Book();
                    BookUtils.CreateBook(book, book.FilePath);
                    break;
            }
            
        }while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}