﻿
namespace PokemonReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public Reviewer Reviewer { get; set; }
        public Pokemon Pokemon { get; set; }

        internal int Count()
        {
            throw new NotImplementedException();
        }

        internal decimal Sum(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}