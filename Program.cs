namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(1, "Harry Potter", 12, 2, "Fantasy");
            Book book2 = new Book(2, "The Housemaid", 10, 4, "Thriller");
            Book book3 = new Book(3, "The Women in White", 16, 1, "Mystery");
            Book book4 = new Book(4, "Boy in the striped pyjama", 20, 0, "Drama");
            Book book5 = new Book(5, "The lord of the rings", 14, 7, "Fantasy");

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            foreach (var book in library.GetFilteredBooks("mystery", 14, 18))
            {
                Console.WriteLine(book.Name + " " + book.Price + " " + book.Count + " " + book.Genre);
            }
            foreach (var book in library.GetBooksByName("harry potter"))
            {
                Console.WriteLine(book.Name + " " + book.Price + " " + book.Count + " " + book.Genre);
            }
            foreach (var book in library.GetBooksById(3))
            {
                Console.WriteLine(book.Name + " " + book.Price + " " + book.Count + " " + book.Genre);
            }
        }
    }
}
