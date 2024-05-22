namespace encapsulation
{
    internal class Library
    {
        public Book[] Books = Array.Empty<Book>();
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length +1);
            Books[Books.Length-1] = book;
        }
        public Book[] GetFilteredBooks(string genrename,double MinPrice, double MaxPrice)
        {
            Book[] filteredbooks = Array.Empty<Book>();

            foreach (var book in Books)
            {
                if (book.Genre.ToLower() == genrename.ToLower() && book.Price >= MinPrice && book.Price <= MaxPrice && book.Count > 0)
                {
                    Array.Resize(ref filteredbooks, filteredbooks.Length + 1);
                    filteredbooks[filteredbooks.Length-1] =book;
                    book.Count -= 1;
                }                
            }
            return filteredbooks;
        }
        public Book[] GetBooksById(int idname)
        {
            Book[] filteredbooks = Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Id == idname && book.Count > 0)
                {
                    Array.Resize(ref filteredbooks, filteredbooks.Length + 1);
                    filteredbooks[filteredbooks.Length - 1] = book;
                }
            }
            return filteredbooks;
        }
        public Book[] GetBooksByName(string namename)
        {
            Book[] filteredbooks = Array.Empty<Book>();
            foreach (var book in Books)
            {

                if (book.Name.ToLower() == namename.ToLower() && book.Count > 0)
                {
                    Array.Resize(ref filteredbooks, filteredbooks.Length + 1);
                    filteredbooks[filteredbooks.Length - 1] = book;
                }
            }
            return filteredbooks;
        }

    }
}
