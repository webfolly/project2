using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp_demo.Models;

namespace WebApp_demo.Controllers
{
    [Produces("application/json")]
    [Route("api/Lecture")]
    public class LectureController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = DataStore.Instance().GetAllLectures();
            return Ok(result);
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = DataStore.Instance().GetLectureById(id);
            return Ok(result);
        }
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Lecture value)
        {
            DataStore.Instance().AddLecture(value);
            return Ok(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update([FromBody]Lecture value)
        {
            Lecture resultOBj = DataStore.Instance().UpdateLecture(value);
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

            bool isRecordExist = DataStore.Instance().DeleteLecture(id);
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
