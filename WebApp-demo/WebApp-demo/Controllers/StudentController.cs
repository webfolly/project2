using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp_demo.Models;

namespace WebApp_demo.Controllers
{
    [Route("api/student")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = DataStore.Instance().GetAllStudents();
            return Ok(result);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = DataStore.Instance().GetStudentById(id);
            return Ok(result);
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Student value)
        {
            DataStore.Instance().AddStudent(value);
            return Ok(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Student value)
        {
            Student resultOBj = DataStore.Instance().UpdateStudent(value);
            IActionResult result;
            if (resultOBj != null)
            {
                result = Accepted(resultOBj);
            }
            else
            {
                result = NotFound();
            }
            return result;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IActionResult result;

            bool isRecordExist = DataStore.Instance().DeleteStudent(id);
            if (isRecordExist)
            {
                result = NoContent();
            }
            else
            {
                result = BadRequest();
            }
            return result;
        }
    }
}
