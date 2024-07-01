using System;
using System.Collections.Generic;

namespace Ex3
{
    internal class Library
    {
        public string Name { get; private set; }
        public List<Book> Collection { get; set; }

        public Library()
        {
            Collection = new List<Book>();
        }

        public Library(List<Book> collection)
        {
            Collection = collection;
        }

        public void AddBook(Book newBook)
        {
            if (Collection.Find(book => book.Title == newBook.Title) == null)
            {
                Collection.Add(newBook);
                Console.WriteLine("Book added successfully!");
            }
            else
            {
                Console.WriteLine("Book already exists!");
            }
        }

        public void RemoveBook(string title, string author, int yearOfPublication)
        {
            Book bookToRemove = new Book(title, author, yearOfPublication);

            if (Collection.Find(book => book.Title == bookToRemove.Title) == null)
            {
                Console.WriteLine("Book not exists!");
            }
            else
            {
                Collection.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully!");
            }
        }

        public void ListCollection()
        {
            Console.WriteLine("Collection:");

            if (Collection != null)
            {
                foreach (Book book in Collection)
                {
                    if (book.ToString() != null)
                    {
                        Console.WriteLine(book);
                    }
                }
            }
        }

        public void ChangeBookTitle(string title, string author, int yearOfPublication, string newTitle)
        {
            Collection.Find(book => book.Title == title && book.Author == author && book.YearOfPublication == yearOfPublication).ChangeTitle(newTitle);
        }

        public void ChangeBookAuthor(string title, string author, int yearOfPublication, string newAuthor)
        {
            Collection.Find(book => book.Title == title && book.Author == author && book.YearOfPublication == yearOfPublication).ChangeAuthor(newAuthor);
        }

        public void ChangeBookYearOfPublication(string title, string author, int yearOfPublication, int newYearOfPublication)
        {
            Collection.Find(book => book.Title == title && book.Author == author && book.YearOfPublication == yearOfPublication).ChangeYearOfPublication(newYearOfPublication);
        }
    }
}
