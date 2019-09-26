using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Zoo.Models;

namespace Zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly ZooContext _context;

        public AnimalsController(ZooContext context)
        {
            _context = context;
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> MakeAnimal(string name)
        {
            Factory animalmaker = new Zoo.Models.Factory();
            IAnimal newanimal = animalmaker.CreateAnimal(name);
            //_context.Animals.Add(newanimal);
            return Created("NewAnimal", new { name = newanimal.Name, speak = newanimal.Speak() });

        }

        //[HttpGet("{name}/speak")]
        //public async Task<IActionResult> AnimalSpeak(string name)
        //{
        //    Factory animalspeaker = new Factory();
        //    IAnimal animal = animalspeaker.CreateAnimal(name);
        //    return Created("AnimalSpeak", animal.Speak());
        //}



    }
}
