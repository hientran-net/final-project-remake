using System.Text;
using System.Threading.Channels;
using Topic2.Models;

namespace Topic2.Helper;

public class BookUtils
{
    public static void CreateBook(Book book, string filePath)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Random rand = new Random();
        
        Console.Clear();
        Console.WriteLine("\tTHÊM SÁCH");
        DateTime startTime;
        
        // enter Isbn
        while (true)
        {
            Console.Clear();
            ShowEnteredData(book);
            
            Console.Write("Mã số sách: ");
            book.Isbn = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(book.Isbn)) break;

            Console.WriteLine("\u274c Mã số sách không được để trống !");
            Thread.Sleep(rand.Next(986, 1587));

            book.Isbn = null;
        }
        
        // enter Title
        while (true)
        {
            Console.Clear();
            ShowEnteredData(book);
            
            Console.Write("Tên sách: ");
            book.Title = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(book.Title)) break;

            Console.WriteLine("\u274c Tên sách không được để trống !");
            Thread.Sleep(rand.Next(986, 1587));
            
            book.Title = null;
        }
        
        
        // enter Subject
        while (true)
        {
            Console.Clear();
            ShowEnteredData(book);
            
            Console.Write("Chủ đề: ");
            book.Subject = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(book.Subject)) break;

            Console.WriteLine("\u274c Chủ đề không được để trống !");
            Thread.Sleep(rand.Next(986, 1587));
            
            book.Subject = null;
        }

        Console.WriteLine("Nhập thành công!!");

    }

    public static void ShowEnteredData(Book book)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("======= Thông tin đã nhập =======");
        Console.WriteLine($"Mã sách: {book.Isbn ?? "[chưa nhập]"}");
        Console.WriteLine($"Tên sách: {book.Title ?? "[chưa nhập]"}");
        Console.WriteLine($"Chủ đề: {book.Subject ?? "[chưa nhập]"}");
        Console.WriteLine($"Tác giả: {book.Author ?? "[chưa nhập]"}");
        Console.WriteLine($"Nhà xuất bản: {book.Publisher ?? "[chưa nhập]"}");
        if (book.PublishDate != null)
        {
            Console.WriteLine($"Ngày xuất bảng: {book.PublishDate}");
        }
        if (book.Pages > 0)
            Console.WriteLine($"Số trang: {book.Pages.ToString()}");
        if (book.Copies > 0)
            Console.WriteLine($"Số bản hiện có: {book.Copies.ToString()}");
        Console.WriteLine("=================================\n");
    }
}