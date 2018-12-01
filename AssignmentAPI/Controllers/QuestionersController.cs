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
    public class QuestionersController : ControllerBase
    {
        // db
        private QuestionModel db;

        public QuestionersController(QuestionModel db)
        {
            this.db = db;
        }

        // GET: api/questioners
        [HttpGet]
        public IEnumerable<questioner> Get()
        {
            return db.questioner.OrderBy(a => a.first_name).ToList();
        }

        // GET: api/questioners/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            questioner questioner = db.questioner.Find(id);

            if (questioner == null)
            {
                return NotFound();
            }
            return Ok(questioner);
        }

        // POST: api/questioners
        [HttpPost]
        public ActionResult Post([FromBody] questioner questioner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.questioner.Add(questioner);
            db.SaveChanges();
            return CreatedAtAction("Post", questioner);
        }

        // PUT: api/questioners/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] questioner questioner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Entry(questioner).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return NoContent();
        }

        // DELETE: api/questioners/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            questioner questioner = db.questioner.Find(id);

            if (questioner == null)
            {
                return NotFound();
            }

            db.questioner.Remove(questioner);
            db.SaveChanges();
            return Ok();
        }
    }
}
