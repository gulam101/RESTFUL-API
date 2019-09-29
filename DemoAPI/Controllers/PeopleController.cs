using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();

        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Correy", Id = 1 });
            people.Add(new Person { FirstName = "Test1", LastName = "Storm", Id = 2 });
            people.Add(new Person { FirstName = "Test2", LastName = "Battery", Id = 3 });
        }
        // GET: api/People
        public List<Person> Get()
        {
            //return new string[] { "value1", "value2" };
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            //As long as it is the same range as the ID then it will find that user
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
        }
    }
}