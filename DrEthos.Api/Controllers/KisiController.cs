using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrEthos.DataAccess.EntityFramework.Repo;
using DrEthos.Entities.Kisiler;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DrEthos.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class KisiController : ControllerBase
    {
        private readonly IDataRepository<Kisi> _repository;
        public KisiController(IDataRepository<Kisi> repository)
        {
            _repository = repository;
        }

        [HttpGet("Kisiler")]
        public IEnumerable<Kisi> GetAll()
        {
            IEnumerable<Kisi> kisiler = _repository.GetAll();
            return kisiler;
        }

        [HttpGet("Kisiler/{id}")]
        public IActionResult GetById(Guid id)
        {
            Kisi kisi = _repository.Get(id);
            if (kisi == null)
            {
                return NotFound("Kişi bulunamadı.");
            }

            return Ok(kisi);
        }

        [HttpPost("Kisiler")]
        public IActionResult Create([FromBody] Kisi model)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(model);
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("Kisiler/{id}")]
        public IActionResult Update(Guid id, [FromBody] Kisi model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(id,model);
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("Kisiler/{id}")]
        public IActionResult Delete(Guid id)
        {
            _repository.Delete(id);
            return Ok();
        }
    }
}
