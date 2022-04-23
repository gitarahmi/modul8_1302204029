﻿
namespace modul8_1302204029.Controllers
{
    public class Movies
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public List<string> Stars { get; set; }
        public string Description { get; set; }

        public Movies(string title, string director, List<string> stars, string description)
        {
            Title = title;
            Director = director;
            Stars = stars;
            Description = description;
        }
    }
}
