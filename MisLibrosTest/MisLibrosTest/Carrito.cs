using System.Collections.Generic;
using System.Linq;

namespace MisLibrosTest
{
    public class Carrito
    {
        public List<Libro> Libros  { get; set; } = new List<Libro>();
       

        public void agregarLibroAlCarrito(Libro libro)
        {
            Libros.Add(libro);
        }

        public bool verificarQueContengaLibro(Libro libro)
        {
            return Libros.Contains(libro);
        }
    }
}