using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CourseAPI.Data;
using CourseAPI.Model;

namespace CourseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppsContext _context;

        public StudentController(AppsContext context)
        {
            _context = context;
        }

        // GET: api/Student
        [HttpGet]
        public IActionResult Getstudents()
        {
            return Ok(_context.students.ToList());
        }

      
        // GET: api/Student/5
        [HttpGet("{id}")]
        public IActionResult GetStudentPoco(int id)
        {
            var studentPoco = _context.students.FindAsync(id);

            if (studentPoco == null)
            {
                return NotFound();
            }

            return Ok(studentPoco);
        }

   

        // POST: api/Student
        [HttpPost]
        public IActionResult PostStudentPoco(StudentPoco studentPoco)
        {
            _context.students.Add(studentPoco);
            _context.SaveChanges();
            return Ok();
        }

        #region Update
        // PUT: api/Student/5
        //[HttpPut("{id}")]
        //public IActionResult PutStudentPoco(int id, StudentPoco studentPoco)
        //{
        //    if (id != studentPoco.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(studentPoco).State = EntityState.Modified;

        //    try
        //    {
        //        _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!_context.students.Any(e => e.Id == id))
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
        #endregion
        #region Delete
        // DELETE: api/Student/5
        //[HttpDelete("{id}")]
        //public ActionResult DeleteStudentPoco(int id)
        //{
        //    var studentPoco = _context.students.Find(id);
        //    if (studentPoco == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.students.Remove(studentPoco);
        //    _context.SaveChangesAsync();

        //    return Ok();
        //}
        #endregion

    }
}
