using Microsoft.AspNetCore.Mvc;
using SonarQube.Poc.Domain.Entidades;
using SonarQube.Poc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SonarQube.Poc.Web.Controllers
{
    [Route("api")]
    [ApiController]
    public class MembroAPIController : ControllerBase
    {
        private readonly IMembroService _membroService;

        public MembroAPIController(IMembroService membroService)
        {
            _membroService = membroService;
        }

        // GET: api/<MembroAPIController>
        [HttpGet("membro")]
        public IEnumerable<Membro> Get()
        {
            IEnumerable<Membro> membros = _membroService.Listar();
            return membros;
        }

        [HttpGet("membro-todos")]
        public IList<Membro> GetAlll()
        {
            IEnumerable<Membro> membros = _membroService.Listar();
            return membros.ToList();
        }

        [HttpGet("membro-todos-assincrona")]
        public async Task<IActionResult> GetAllAsync()
        {
            IEnumerable<Membro> membros = _membroService.Listar();
            return Ok(membros);
        }

        [HttpGet("membro-todos-nao-assincrona")]
        public IActionResult GetAllNotAsync()
        {
            IEnumerable<Membro> membros = _membroService.Listar();
            return Ok(membros);
        }

        // GET api/<MembroAPIController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MembroAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MembroAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MembroAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
