﻿namespace encapsulation
{
    public class Product
    {
        private double _price;
        private int _count;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price 
        { 
            get
            {
                return _price;
            }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
            } 
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value >= 0)
                {
                    _count = value;
                }
            }
        }


        public Product(int id)
        {
             Id = id;
        }
        public Product(int id, string name) : this(id) 
        {
             Name = name;
        }
        public Product(int id, string name, double price) : this(id, name) 
        {
             Price = price;
        }
        public Product(int id, string name, double price, int count) : this(id, name, price) 
        {
             Count = count;
        }
        

    }
}
