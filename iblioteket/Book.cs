﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iblioteket
{
    class Book
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private int published;

        public int Published
        {
            get { return published; }
            set { published = value; }
        }

        private int pages;

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        public Book(string title, string author, int published, int pages)
        {
            Title = title;
            Author = author;
            Published = published;
            Pages = pages;
        }
    }
}
