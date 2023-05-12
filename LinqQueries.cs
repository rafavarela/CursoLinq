using System.Text.Json;
public class LinqQueries 
{
    private List<Book> librosCollection = new List<Book>();
    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = JsonSerializer.Deserialize<List<Book>>(json, 
                    new JsonSerializerOptions() {
                        PropertyNameCaseInsensitive = true
                    });
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> GetPythonBooks() 
    {
        return librosCollection.Where(l => l.Categories.Contains("Python"));
    }

    public IEnumerable<Book> GetJavaBooks() 
    {
        return librosCollection
                .Where(l => l.Categories.Contains("Java"))
                .OrderBy(l => l.Title);
    }

    public IEnumerable<Book> GetBooksPages450() 
    {
        return librosCollection
                .Where(l => l.PageCount > 450)
                .OrderByDescending(l => l.PageCount);
    }

    public IEnumerable<Book> GetRecentJavaBooks() 
    {
        return librosCollection
                .Where(l => l.Categories.Contains("Java"))
                .OrderByDescending(l => l.PublishedDate)
                .Take(3);
    }

    public IEnumerable<Book> GetRecentJavaBooks2() 
    {
        return librosCollection
                .Where(l => l.Categories.Contains("Java"))
                .OrderBy(l => l.PublishedDate)
                .TakeLast(3);
    }

    public IEnumerable<Book> Get34Books400() 
    {
        return librosCollection
                .Where(l => l.PageCount > 400)
                .Skip(2)
                .Take(2);
    }

    public IEnumerable<Book> GetLibrosTop3()
    {
        return librosCollection
                .Take(3)
                .Select(l => new Book { Title = l.Title, PageCount = l.PageCount });
    }

    public int TotalLibros200y500Pags()
    {
        return librosCollection
                .Where(l => l.PageCount >= 200)
                .Where(l => l.PageCount <= 500)
                .Count();
    }

    public long TotalLibros200y500Pags2()
    {
        return librosCollection
                .LongCount(l => l.PageCount >= 200 && l.PageCount <= 500);
    }

    public DateTime GetMinPublishedDate()
    {
        return librosCollection
                .Min(l => l.PublishedDate);
    }

    public int GetMaxPages()
    {
        return librosCollection
                .Max(l => l.PageCount);
    }

    public Book GetBookMinPages()
    {
        return librosCollection
                .Where(l => l.PageCount > 0)
                .MinBy(l => l.PageCount);
    }

    public Book GetBookMaxPublishedDate()
    {
        return librosCollection
                .MaxBy(l => l.PublishedDate);
    }

    public int GetBookPages500()
    {
        return librosCollection
                .Where(l => l.PageCount >= 0 && l.PageCount <= 500)
                .Sum(l => l.PageCount);
    }

    public string Libros2015Concatenados()
    {
        var titulos = librosCollection
                    .Where(l => l.PublishedDate.Year > 2015)
                    .Aggregate("", (acum, elem) => $"{acum} {elem.Title} -");

        return titulos.Remove(titulos.Length - 1);
    }

}