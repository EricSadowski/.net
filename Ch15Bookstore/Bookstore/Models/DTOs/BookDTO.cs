﻿using System.Collections.Generic;

namespace Bookstore.Models
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public Dictionary<int, string> Authors { get; set; }

        public void Load(Book book)
        {
            BookId = book.BookId;
            Title = book.Title;
            Price = book.Price;
            Authors = new Dictionary<int, string>();
            foreach (BookAuthor ba in book.BookAuthors) {
                Authors.Add(ba.Author.AuthorId, ba.Author.FullName);
            }
        }
    }

}
