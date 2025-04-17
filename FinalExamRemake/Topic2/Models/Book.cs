namespace Topic2.Models;

public class Book
{
    private readonly string filePath =
        @"D:\University\CN2303CLCB_K23\Kì 1 Năm 1\Kĩ_Thuật_Lập_Trình\final-project-remake\FinalExamRemake\Topic2\Resources\books.txt";

    private string isbn;
    private string title;
    private string subject;
    private string author;
    private string publisher;
    private string publishDate;
    private int pages;
    private int copies;
    
    public string Isbn { get => isbn; set => isbn = value; }
    public string Title { get => title; set => title = value; }
    public string Subject { get => subject; set => subject = value; }
    public string Author { get => author; set => author = value; }
    public string Publisher { get => publisher; set => publisher = value; }
    public string PublishDate { get => publishDate; set => publishDate = value; }
    public int Pages { get => pages; set => pages = value; }
    public int Copies { get => copies; set => copies = value; }
    public string FilePath { get => filePath; }

    public Book()
    {
        // constructor
    }

    ~Book()
    {
        // destructor
    }
}