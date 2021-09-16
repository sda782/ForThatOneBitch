using FirstRESTController.Managers;
using FirstRESTController.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstRESTController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsManager _manager = new ItemsManager();

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public IEnumerable<Item> Post([FromBody] Item value)
        {
            _manager.Add(value);

            return _manager.GetAll();
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public IEnumerable<Item> Put(int id, [FromBody] Item value)
        {
            _manager.Update(id, value);

            return _manager.GetAll();
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Item> Delete(int id)
        {
            _manager.Delete(id);

            return _manager.GetAll();
        }
    }
}
