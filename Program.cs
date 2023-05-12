LinqQueries queries = new LinqQueries();
var libros = queries.TodaLaColeccion();

// Reto 1
// var libros2k = libros.Where(l => l.PublishedDate.Year > 2000);
// var libros2k = from l in libros 
//                 where l.PublishedDate.Year > 2000
//                 select l;

// Reto 2
// var libros250Action = libros
//     .Where(l => l.PageCount > 250)
//     .Where(l => l.Title.Contains("in Action"));

// var libros250Action = from l in libros 
//                     where l.PageCount > 250 && 
//                     l.Title.Contains("in Action")
//                     select l;


// bool librosStatus = libros.All(l => l.Status != string.Empty);
// Console.WriteLine($"Todos los libros tienen status?: {librosStatus}");

// bool libroPub2005 = libros.Any(l => l.PublishedDate.Year == 2005);
// Console.WriteLine($"Algún libro fue publicado en el 2005?: {libroPub2005}");

//ImprimirValores(libros250Action);

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("--------------------------------------------------------------------------------------------");
    Console.WriteLine("{0,-60} {1,15} {2,15}", "Titulo", "N. Pags", "Fecha Pub");
    Console.WriteLine("--------------------------------------------------------------------------------------------");

    foreach(var l in listadelibros) 
    {
        Console.WriteLine("{0,-60} {1,15} {2,15}", l.Title, l.PageCount, l.PublishedDate.ToShortDateString());
    }
}

//ImprimirValores(queries.GetPythonBooks());
//ImprimirValores(queries.GetJavaBooks());
//ImprimirValores(queries.GetBooksPages450());
//ImprimirValores(queries.GetRecentJavaBooks2());
// ImprimirValores(queries.Get34Books400());
//ImprimirValores(queries.GetLibrosTop3());
// var librosTop3 = libros.Take(3).Select(l => new { l.Title, l.PageCount });
// librosTop3.ToList().ForEach(l => Console.WriteLine($"{l.Title}: {l.PageCount}"));
//Console.WriteLine($"Libros entre 200 y 500 páginas {queries.TotalLibros200y500Pags()}");
// Console.WriteLine($"Libros entre 200 y 500 páginas {queries.TotalLibros200y500Pags2()}");
//Console.WriteLine($"Libro con menor fecha de publicación {queries.GetMinPublishedDate()}");
//Console.WriteLine($"Libro con mas paginas {queries.GetMaxPages()}");

// List<Book> listadelibros = new List<Book>();
// listadelibros.Add(queries.GetBookMinPages());
// ImprimirValores(listadelibros);

// var libroPubRecent = queries.GetBookMaxPublishedDate();
// Console.WriteLine($"{libroPubRecent.Title} - {libroPubRecent.PublishedDate}");


// Console.WriteLine($"Suma de paginas de libros en entre 0 y 500: {queries.GetBookPages500()}");
Console.WriteLine($"Titulos de libros publicados despues del 2015:{queries.Libros2015Concatenados()}");

// Animales ---------------------------------------------------------------------------------
// List<Animal> animales = new List<Animal>();
// animales.Add(new Animal() { Nombre = "Hormiga", Color = "Rojo" });
// animales.Add(new Animal() { Nombre = "Lobo", Color = "Gris" });
// animales.Add(new Animal() { Nombre = "Elefante", Color = "Gris" });
// animales.Add(new Animal() { Nombre = "Pantegra", Color = "Negro" });
// animales.Add(new Animal() { Nombre = "Gato", Color = "Negro" });
// animales.Add(new Animal() { Nombre = "Iguana", Color = "Verde" });
// animales.Add(new Animal() { Nombre = "Sapo", Color = "Verde" });
// animales.Add(new Animal() { Nombre = "Camaleon", Color = "Verde" });
// animales.Add(new Animal() { Nombre = "Gallina", Color = "Blanco" });

// var animalesOrdenados = animales.OrderBy(a => a.Nombre);
// animalesOrdenados.ToList().ForEach(a => Console.WriteLine(a.Nombre));

// // Escribe tu código aquí
// // filtra todos los animales que sean de color verde que su nombre inicie con una vocal

// var animalesVerdesVocal = animales
//                             .Where(a => a.Color == "Verde")
//                             .Where(a => "aeiouAEIOU".IndexOf(a.Nombre[0]) >= 0);

// animalesVerdesVocal.ToList().ForEach(a => Console.WriteLine($"{a.Nombre}: {a.Color}"));