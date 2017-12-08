using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi1.Models;

namespace TestApi1.Controllers
{
    public class PersonAPIController : ApiController
    {
        // GET: api/Person
        public List<PersonViewModel> Get()
        {
            var personsList = new List<PersonViewModel> {
                new PersonViewModel {
                    Id = 1234,
                    FirstName = "Fahad",
                    LastName = "Zamir",
                    JobTitle = "Application Architect"
                },
                new PersonViewModel {
                    Id = 5555,
                    FirstName = "John",
                    LastName = "Doe",
                    JobTitle = "Software Engineer"
                }
            };
            
            return personsList;
        }

        // GET: api/Person/5
        public string Get(int id)
        {            
            return "value";
        }

        // POST: api/Person
        public void Post([FromBody]PersonViewModel value)
        {
            var person = new PersonViewModel();
            person.FirstName = value.FirstName;
            person.LastName = value.LastName;
            person.JobTitle = value.JobTitle;
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
        }
    }
}
