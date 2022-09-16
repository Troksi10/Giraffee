using System;
using System.Collections.Generic;
using System.Text;

namespace Giraffee
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string Title, string Director, string Rating)
        {
            title = Title;
            director = Director;
            rating = Rating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}