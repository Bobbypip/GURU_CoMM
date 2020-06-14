using AutoMapper;
using GURU_CoMM.DTOs;
using GURU_CoMM.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GURU_CoMM.Controllers
{
    [ApiController]
    [Route("pets")]
    public class PetsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PetsController(
            ApplicationDbContext context,
            IMapper mapper
            )
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetPets")]
        public async Task<ActionResult<List<PetDto>>> Get(int pageNumber = 1, int recordsQuantity = 3)
        {
            if (recordsQuantity > 100)
            {
                recordsQuantity = 100;
            }
            if (recordsQuantity <= 0)
            {
                recordsQuantity = 3;
            }
            if (pageNumber < 0)
            {
                pageNumber = 1;
            }

            var query = context.Pets.AsQueryable();
            var recordsTotal = query.Count();

            var entities = await query
                .Skip(recordsQuantity * (pageNumber - 1))
                .Take(recordsQuantity)
                .ToListAsync();

            Response.Headers["x-total-records"] = recordsTotal.ToString();
            Response.Headers["x-pages-quantity"] =
                ((int)Math.Ceiling((double)recordsTotal / recordsQuantity)).ToString();
            Response.Headers.Add("POST", Url.Link("GetPets", null));

            var dtos = mapper.Map<List<PetDto>>(entities);
            return dtos;
        }

        [HttpGet("{id:int}", Name = "GetPet")]
        public async Task<ActionResult<PetDto>> Get(long id)
        {
            var entity = await context.Pets.FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null)
            {
                return NotFound();
            }

            return new PetDto()
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }

        [HttpPost(Name = "CreatePet")]
        public async Task<ActionResult> Post([FromBody] PetCreationDto petCreationDTO)
        {
            var entity = mapper.Map<Pet>(petCreationDTO);
            context.Add(entity);
            await context.SaveChangesAsync();
            var petDTO = mapper.Map<PetDto>(entity);

            return new CreatedAtRouteResult("GetPet", new { id = petDTO.Id }, petDTO);
        }
    }
}
