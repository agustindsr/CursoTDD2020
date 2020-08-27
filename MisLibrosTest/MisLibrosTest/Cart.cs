using System;
using System.Collections.Generic;
using System.Linq;

namespace MisLibrosTest
{
    public class Cart
    {
        public List<Object> Books  { get; set; } = new List<Object>();
        public List<Object> Catalog { get; set; } = new List<Object>();

        public Cart()
        {
            
        }
        public Cart(List<Object> catalog)
        {
            this.Catalog = catalog;
        }
        public void addBookToCart(Object book, int quantity)
        {
            if (Catalog.Contains(book))
            {
                for (int i = 0; i<quantity; i++)
                {
                    Books.Add(book);

                }
            }
           
        }

        public bool checkItContainsBook(Object book, int quantity)
        {
            return Books.Where(x => x == book).Count() == quantity;
        }
    }
}