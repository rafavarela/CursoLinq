LinqQueries queries = new LinqQueries();
ImprimirValores(queries.TodaLaColeccion());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1,15} {2,15}", "Titulo", "N. Pags", "Fecha Pub");

    foreach(var l in listadelibros) 
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", l.Title, l.PageCount, l.PublishedDate.ToShortDateString());
    }
}
