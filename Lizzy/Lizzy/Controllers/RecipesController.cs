using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lizzy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lizzy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetDishes([FromQuery]int count)
        {
            Recipe[] Recipes = {
            new() { Title = "Oxtail" },
            new() { Title = "Burger" },
            new() { Title = "Green Salad" },
            new() { Title = "Beans" }
            };
            
            return Ok(Recipes.Take(count));
        }
        [HttpPost]
        public ActionResult CreateNewRecipes( [FromBody] Recipe newRecipe)
        {
            bool badThingsHappen = false;
            if (badThingsHappen)
                return BadRequest();
            return Created("", newRecipe);
        }
        [HttpDelete]
        public ActionResult DeleteRecipes()
        {
            bool badThingsHappen = false;
            if (badThingsHappen)
                return BadRequest();
            return NoContent();
        }
        [HttpPut]
        public ActionResult UpdateRecipes()
        {
            return NotFound();
        }
    }
}
