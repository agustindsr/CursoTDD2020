using System.Linq;
using NUnit.Framework;

namespace MisLibrosTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CrearCarritoYValidarQueEstaVacio()
        {
            Carrito carrito = new Carrito();
            Assert.True(!carrito.Libros.Any());
        }
        [Test]
        public void AgregarUnLibroACarritoYValidarQueLoContenga()
        {
            Carrito carrito = new Carrito();
            Libro libro = new Libro();
            carrito.agregarLibroAlCarrito(libro);

            Assert.True(carrito.verificarQueContengaLibro(libro));
        }

        [Test]
        public void AgregarMasDeUnLibroACarritoYValidarQueLosContenga()
        {
            Carrito carrito = new Carrito();
            Libro libro1 = new Libro();

            carrito.agregarLibroAlCarrito(libro1);
            carrito.agregarLibroAlCarrito(libro1);

            Assert.True(carrito.verificarQueContengaLibro(libro1));
        }
    }
}