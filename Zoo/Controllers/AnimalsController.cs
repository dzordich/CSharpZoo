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
            return Created("NewAnimal", newanimal);

        }

        [HttpGet("{name}/speak")]
        public async Task<IActionResult> AnimalSpeak(string name)
        {
            Factory animalspeaker = new Factory();
            IAnimal animal = animalspeaker.CreateAnimal(name);
            return Created("AnimalSpeak", animal.Speak());
        }



        // GET: api/Animals
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<IAnimal>>> GetAnimals()
        //{
        //    return await _context.Animals.ToListAsync();
        //}

        //// GET: api/Animals/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<IAnimal>> GetAnimal(long id)
        //{
        //    var animal = await _context.Animals.FindAsync(id);

        //    if (animal == null)
        //    {
        //        return NotFound();
        //    }

        //    return animal;
        //}

        //// POST: api/Animals
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
        //{
        //    _context.Animals.Add(animal);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction(nameof(GetAnimal), new { id = animal.Id }, animal);
        //}

        //private bool AnimalExists(long id)
        //{
        //    return _context.Animals.Any(e => e.Id == id);
        //}
    }
}
