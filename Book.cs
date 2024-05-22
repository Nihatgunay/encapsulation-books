namespace encapsulation
{
    public class Book : Product
    {
        public string Genre {  get; set; }
        public Book(int id) : base(id) 
        {            
        }
        public Book(int id, string name) : base(id, name)
        {
        }
        public Book(int id, string name, double price) : base(id, name, price) 
        {           
        }
        public Book(int id, string name, double price, int count) : base(id, name, price, count)
        {
        }
        public Book(int id, string name, double price, int count, string genre) : base(id, name, price, count)
        {
            Genre = genre;  
        }

    }
}
