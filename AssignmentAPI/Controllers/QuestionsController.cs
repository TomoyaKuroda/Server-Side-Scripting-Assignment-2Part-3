using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        // db
        private QuestionModel db;

        public QuestionsController(QuestionModel db)
        {
            this.db = db;
        }

        // GET: api/questions
        [HttpGet]
        public IEnumerable<question> Get()
        {
            return db.question.OrderBy(a => a.title).ToList();
        }

        // GET: api/questions/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            question question = db.question.Find(id);

            if (question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }

        // POST: api/questions
        [HttpPost]
        public ActionResult Post([FromBody] question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.question.Add(question);
            db.SaveChanges();
            return CreatedAtAction("Post", question);
        }

        // PUT: api/questions/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] question question)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(question).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }

        // DELETE: api/questions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            question question = db.question.Find(id);

            if (question == null)
            {
                return NotFound();
            }

            db.question.Remove(question);
            db.SaveChanges();
            return Ok();
        }
    }
}