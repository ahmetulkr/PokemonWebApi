﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;

        }

        public Pokemon GetPokemon(int id)
        {
            return _context.Pokemon.Where(p = p => p.Id == pokeid).FirstOrDefault();
        } 
        public Pokemon GetPokemon(string name)
        {
            return _context.Pokemon.Where(p = p => p.Name == name).FirstOrDefault();
        }

        public decimal GetPokemonRating(int pokeid)
        {
           var review = _context.Reviews.Where(p=> p.Pokemon.Id == pokeid).FirstOrDefault();
            if (review.Count()<=0)
                return 0;
            return ((decimal)review.Sum(review => r.Rating) / review.Count());
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return _context.Pokemon.OrderBy(p => p.Id).ToList();        
        
        }

        public bool PokemonExists(int pokeid)
        {
            return _context.Pokemon.Any(p => p.Id == pokeid);
        }
    }
}