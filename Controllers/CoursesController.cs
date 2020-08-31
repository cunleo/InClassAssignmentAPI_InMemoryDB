
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CourseAPI.Data;
using CourseAPI.Model;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly  AppsContext _context;

        public CoursesController(AppsContext context)
        {
            _context = context;
        }

        // GET: api/Courses
        [HttpGet]
        public IActionResult  GetCoursePoco()
        {
            return Ok(_context.courses.ToList());
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public IActionResult GetCoursePoco(int id)
        {
            var coursePoco =  _context.courses.Find(id);

            if (coursePoco == null)
            {
                return NotFound();
            }

            return Ok(coursePoco);
        }

        [HttpPost]
        public IActionResult PostCoursePoco(CoursePoco coursePoco)
        {
            _context.courses.Add(coursePoco);
           _context.SaveChangesAsync();
            return Ok();
        }


        #region Update
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutCoursePoco(int id, CoursePoco coursePoco)
        //{
        //    if (id != coursePoco.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(coursePoco).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!CoursePocoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        //private bool CoursePocoExists(int id)
        //{
        //    return _context.courses.Any(e => e.Id == id);
        //}

        #endregion
        #region Delete
        //// DELETE: api/Courses/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<CoursePoco>> DeleteCoursePoco(int id)
        //{
        //    var coursePoco = await _context.courses.FindAsync(id);
        //    if (coursePoco == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.courses.Remove(coursePoco);
        //    await _context.SaveChangesAsync();

        //    return coursePoco;
        //}
        #endregion


    }
}
