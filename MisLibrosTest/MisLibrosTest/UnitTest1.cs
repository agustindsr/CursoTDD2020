using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;

namespace MisLibrosTest
{
    public class Tests
    {
        private Object book1;
        private Object book2;
        private Object book3;
        private List<Object> catalog = new List<object>();
        private Cart cart;



        [SetUp]
        public void Setup()
        {
            CreateBook();
            CreateCatalog(new List<Object> {book1, book2});
            CreateCart(catalog);
        }

        private void CreateCart(List<Object> catalogo)
        {
            cart = new Cart(catalogo);
        }

        private void CreateCatalog(List<Object> libros)
        {
            catalog.AddRange(libros);
        }

        private void CreateBook()
        {
            book1 = new Object();
            book2 = new Object();
            book3 = new Object();
        }

        [Test]
        public void CreateCartAndCheckThatItsEmpty()
        {
            Assert.True(!cart.Books.Any());
        }
        [Test]
        public void  AddBookToCartAndCheckThatItContainsIt()
        {
            cart.addBookToCart(book1,1);
            Assert.True(cart.checkItContainsBook(book1, 1));
        }

        [Test]
        public void  AddMoreThanABookToCartAndCheckThatItContainsThem()
        {
            cart.addBookToCart(book1,2);
            Assert.True(cart.checkItContainsBook(book1, 2));
        }

        [Test]
        public void AddABookThatIsNotInTheCatalogShouldNotBeAdded()
        {
            cart.addBookToCart(book3, 1);
            Assert.False(cart.checkItContainsBook(book3, 1));
        }

        [Test]
        public void AddNegativeQuantityOfABookShouldNotAdd()
        {
            cart.addBookToCart(book1, -1);
            Assert.False(cart.checkItContainsBook(book1, -1));
        }
    }
}