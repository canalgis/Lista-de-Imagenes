using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace xBindDataExample.Models
{


    public class Book
    {
     
        public int BookId { get; set; }
        public string Titulo { get; set; }
        public string Consola { get; set; }
        public string Imagen { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Titulo = "RISE OF THE TOMB RAIDER", Consola = "PS4", Imagen = "Assets/1.jpg" });
            books.Add(new Book { BookId = 2, Titulo = "GOD OF WAR III REMASTERED", Consola = "PS4", Imagen = "Assets/2.jpg" });
            books.Add(new Book { BookId = 3, Titulo = "BIOSHOCK THE COLLECTION", Consola = "XBOX ONE", Imagen = "Assets/3.jpg" });
            books.Add(new Book { BookId = 4, Titulo = "GRAND THEFT AUTO V", Consola = "XBOX ONE", Imagen = "Assets/4.jpg" });
            books.Add(new Book { BookId = 5, Titulo = "DONKEY KONG COUNTRY RETURNS", Consola = "WII", Imagen = "Assets/5.jpg" });
            books.Add(new Book { BookId = 6, Titulo = "SUPER MARIO GALAXY 2", Consola = "WII", Imagen = "Assets/6.jpg" });
           

            return books;
        } 
    }
}