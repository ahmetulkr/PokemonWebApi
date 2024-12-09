
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        private readonly IPokemonRepository _pokemonRepository;
        private readonly DataContext context;
        public PokemonController(IPokemonRepository pokemonRepository, DataContext context)
        {
            _pokemonRepository = pokemonRepository;
            this.context = context;

        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Pokemon>))]
        public IActionResult GetPokemon()
        {
            var pokemons = _pokemonRepository.GetPokemons();
            if (!ModelState.IsValid)

                return BadRequest(ModelState);

            return Ok(pokemons);
        }
    }
}
