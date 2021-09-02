using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            string[] Recipes = { "Burger", "Water", "Sweets", "Mealies" };
            if (!Recipes.Any()){ 
                return NotFound();
                }
            return Ok(Recipes.Take(count));
        }
        [HttpPost]
        public ActionResult CreateNewRecipes()
        {
            return BadRequest();
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
