using System.Text.Json;
public class LinqQueries 
{
    private List<Book> librosColection = new List<Book>();
    public LinqQueries()
    {
        using(StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosColection = JsonSerializer.Deserialize<List<Book>>(json, 
                    new JsonSerializerOptions() {
                        PropertyNameCaseInsensitive = true
                    });
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosColection;
    }
}