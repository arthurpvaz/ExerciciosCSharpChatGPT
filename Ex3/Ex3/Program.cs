using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            bool programIsRunning = true;

            while (programIsRunning)
            {
                Console.WriteLine("----------- Library manager ----------");
                Console.WriteLine("1) Add a book");
                Console.WriteLine("2) Remove a book");
                Console.WriteLine("3) List collection");
                Console.WriteLine("4) Change a book");
                Console.WriteLine("5) Exit");

                Console.WriteLine();
                Console.Write("Option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Adding a book...");
                        Console.WriteLine();
                        Console.Write("Book title: ");
                        string title = Console.ReadLine();

                        Console.Write("Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Year of publication: ");
                        int yearOfPublication = int.Parse(Console.ReadLine());

                        library.AddBook(new Book(title, author, yearOfPublication));
                        break;
                    case 2:
                        Console.WriteLine("Removing a book...");
                        Console.WriteLine();
                        Console.Write("Book title: ");
                        title = Console.ReadLine();

                        Console.Write("Author: ");
                        author = Console.ReadLine();

                        Console.Write("Year of publication: ");
                        yearOfPublication = int.Parse(Console.ReadLine());
                        library.RemoveBook(title, author, yearOfPublication);
                        break;
                    case 3:
                        library.ListCollection();
                        break;
                    case 4:
                        if (library.Collection.Count > 0)
                        {
                            Console.WriteLine(library.Collection.Count);
                            Console.WriteLine("Changing a book...");
                            Console.WriteLine("1) Change title");
                            Console.WriteLine("2) Change author");
                            Console.WriteLine("3) Change year of publiction");

                            int internalOption = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter actual book information");
                            Console.WriteLine();
                            Console.Write("Book title: ");
                            title = Console.ReadLine();

                            Console.Write("Author: ");
                            author = Console.ReadLine();

                            Console.Write("Year of publication: ");
                            yearOfPublication = int.Parse(Console.ReadLine());

                            if (internalOption == 1)
                            {
                                Console.Write("New title: ");
                                string newTitle = Console.ReadLine();

                                library.ChangeBookTitle(title, author, yearOfPublication, newTitle);
                            }
                            else if (internalOption == 2)
                            {
                                Console.Write("New author: ");
                                string newAuthor = Console.ReadLine();

                                library.ChangeBookAuthor(title, author, yearOfPublication, newAuthor);
                            }
                            else if (internalOption == 3)
                            {
                                Console.WriteLine("New year of publication: ");
                                int newYearOfPublication = int.Parse(Console.ReadLine());

                                library.ChangeBookYearOfPublication(title, author, yearOfPublication, newYearOfPublication);
                            }
                            else
                            {
                                Console.WriteLine("Invalid option!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no books to change!");
                        }
                        break;
                    case 5:
                        programIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
            }
        }
    }
}