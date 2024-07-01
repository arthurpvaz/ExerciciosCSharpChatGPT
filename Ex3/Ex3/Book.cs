using System;

namespace Ex3
{
    internal class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int? YearOfPublication { get; private set; }

        public Book()
        {

        }

        public Book(string title)
        {
            Title = title;
        }

        public Book(string title, string author) : this(title)
        {
            Author = author;
        }

        public Book(string title, int yearOfPublication) : this(title)
        {
            YearOfPublication = yearOfPublication;
        }

        public Book(string title, string author, int yearOfPublication) : this(title, author)
        {
            YearOfPublication = yearOfPublication;
        }

        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void ChangeYearOfPublication(int yearOfPublication)
        {
            YearOfPublication = yearOfPublication;
        }

        public override string? ToString()
        {
            if (Title != null && Author == null && YearOfPublication == null)
            {
                return $"{Title}";
            }
            else if (Title != null && Author != null && YearOfPublication == null)
            {
                return $"{Title} ({Author})";
            }
            else if (Title != null && Author == null && YearOfPublication != null)
            {
                return $"{Title} - {YearOfPublication}";
            }
            else if (Title != null && Author != null && YearOfPublication != null)
            {
                return $"{Title} - {YearOfPublication} ({Author})";
            }
            else
            {
                return null;
            }
        }
    }
}
