using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhonebookLibrary;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PhonebookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // GET: api/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            JsonDataAccess da = new JsonDataAccess();
            Phonebook.Contacts = new List<Contact>();
            da.LoadData();
            return Phonebook.Contacts;
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return Phonebook.Contacts.Where(c => c.Id == id).FirstOrDefault();
        }

        // POST api/<ContactController>
        [HttpPost]
        public void Post(Contact c)
        {
            if (c != null)
            {
                Phonebook.Contacts.Add(c);
                JsonDataAccess da = new JsonDataAccess();
                da.SaveData();
            }
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
