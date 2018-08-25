using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Ritu_AKQA_Code.Models;
using Ritu_AKQA_Code.Repository;

namespace Ritu_AKQA_Code.Controllers
{
    public class NumberToWordController : ApiController
    {
        IPersonRepository _repository;
        public NumberToWordController(IPersonRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Get the Person details with currency converted to word
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetPerson(Person person)
        {
            var personOutput = _repository.GetPerson(person);

            if (personOutput == null)
            {
                return NotFound();
            }
            return Ok(personOutput);
        }

    }
}
