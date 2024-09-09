//using Institute.Data;
//using Institute.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//namespace Institute.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    [Authorize(Roles = "admin")]
//    public class AdminController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public AdminController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // Get all students
//        [HttpGet("students")]
//        public async Task<IActionResult> GetStudents()
//        {
//            var students = await _context.Students.ToListAsync();
//            return Ok(students);
//        }

//        // Get all trainees
//        [HttpGet("trainees")]
//        public async Task<IActionResult> GetTrainees()
//        {
//            var trainees = await _context.Trainees.ToListAsync();
//            return Ok(trainees);
//        }

//        // Add or update student
//        [HttpPost("student")]
//        public async Task<IActionResult> AddOrUpdateStudent([FromBody] Student student)
//        {
//            if (student.Id == 0)
//                _context.Students.Add(student);
//            else
//                _context.Students.Update(student);

//            await _context.SaveChangesAsync();
//            return Ok(student);
//        }

//        // Add or update trainee
//        [HttpPost("trainee")]
//        public async Task<IActionResult> AddOrUpdateTrainee([FromBody] Trainee trainee)
//        {
//            if (trainee.Id == 0)
//                _context.Trainees.Add(trainee);
//            else
//                _context.Trainees.Update(trainee);

//            await _context.SaveChangesAsync();
//            return Ok(trainee);
//        }

//        // Delete student
//        [HttpDelete("student/{id}")]
//        public async Task<IActionResult> DeleteStudent(int id)
//        {
//            var student = await _context.Students.FindAsync(id);
//            if (student == null)
//                return NotFound();

//            _context.Students.Remove(student);
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }

//        // Delete trainee
//        [HttpDelete("trainee/{id}")]
//        public async Task<IActionResult> DeleteTrainee(int id)
//        {
//            var trainee = await _context.Trainees.FindAsync(id);
//            if (trainee == null)
//                return NotFound();

//            _context.Trainees.Remove(trainee);
//            await _context.SaveChangesAsync();
//            return NoContent();
//        }
//    }
//}





//using Institute.Data;
//using Institute.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Institute.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class AdminController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public AdminController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // Get all users
//        [HttpGet]
//        public async Task<IActionResult> GetAllUsers()
//        {
//            var users = await _context.Users.ToListAsync();
//            return Ok(users);
//        }

//        // Get a single user by ID
//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetUser(int id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//            return Ok(user);
//        }

//        // Add a new user
//        [HttpPost]
//        public async Task<IActionResult> CreateUser([FromBody] User user)
//        {
//            if (user == null)
//            {
//                return BadRequest("User is null.");
//            }

//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
//        }

//        // Update an existing user
//        [HttpPut("{id}")]
//        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
//        {
//            if (id != user.Id)
//            {
//                return BadRequest("User ID mismatch.");
//            }

//            _context.Entry(user).State = EntityState.Modified;
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // Delete a user
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteUser(int id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            _context.Users.Remove(user);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }
//    }
//}
//using Institute.Data;
//using Institute.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

//namespace Institute.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class AdminController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public AdminController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // Student CRUD operations

//        // Get all students
//        [HttpGet("students")]
//        public async Task<IActionResult> GetAllStudents()
//        {
//            var students = await _context.Students.ToListAsync();
//            return Ok(students);
//        }

//        // Get a single student by ID
//        [HttpGet("students/{id}")]
//        public async Task<IActionResult> GetStudent(int id)
//        {
//            var student = await _context.Students.FindAsync(id);
//            if (student == null)
//            {
//                return NotFound();
//            }
//            return Ok(student);
//        }

//        // Add a new student
//        [HttpPost("students")]
//        public async Task<IActionResult> CreateStudent([FromBody] Student student)
//        {
//            if (student == null)
//            {
//                return BadRequest("Student is null.");
//            }

//            _context.Students.Add(student);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
//        }

//        // Update an existing student
//        [HttpPut("students/{id}")]
//        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student student)
//        {
//            if (id != student.Id)
//            {
//                return BadRequest("Student ID mismatch.");
//            }

//            _context.Entry(student).State = EntityState.Modified;
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // Delete a student
//        [HttpDelete("students/{id}")]
//        public async Task<IActionResult> DeleteStudent(int id)
//        {
//            var student = await _context.Students.FindAsync(id);
//            if (student == null)
//            {
//                return NotFound();
//            }

//            _context.Students.Remove(student);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // User CRUD operations

//        // Get all users
//        [HttpGet("users")]
//        public async Task<IActionResult> GetAllUsers()
//        {
//            var users = await _context.Users.ToListAsync();
//            return Ok(users);
//        }

//        // Get a single user by ID
//        [HttpGet("users/{id}")]
//        public async Task<IActionResult> GetUser(int id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }
//            return Ok(user);
//        }

//        // Add a new user
//        [HttpPost("users")]
//        public async Task<IActionResult> CreateUser([FromBody] User user)
//        {
//            if (user == null)
//            {
//                return BadRequest("User is null.");
//            }

//            _context.Users.Add(user);
//            await _context.SaveChangesAsync();

//            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
//        }

//        // Update an existing user
//        [HttpPut("users/{id}")]
//        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
//        {
//            if (id != user.Id)
//            {
//                return BadRequest("User ID mismatch.");
//            }

//            _context.Entry(user).State = EntityState.Modified;
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        // Delete a user
//        [HttpDelete("users/{id}")]
//        public async Task<IActionResult> DeleteUser(int id)
//        {
//            var user = await _context.Users.FindAsync(id);
//            if (user == null)
//            {
//                return NotFound();
//            }

//            _context.Users.Remove(user);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }
//    }
//}


using Institute.Data;
using Institute.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Institute.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        #region Student CRUD

        [HttpGet("Students")]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _context.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet("Students/{id}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost("Students")]
        public async Task<IActionResult> CreateStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudent), new { id = student.Id }, student);
        }

        [HttpPut("Students/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student student)
        {
            if (id != student.Id)
            {
                return BadRequest();
            }

            _context.Entry(student).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        [HttpDelete("Students/{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }

        #endregion

        #region Trainee CRUD

        [HttpGet("Trainees")]
        public async Task<IActionResult> GetTrainees()
        {
            var trainees = await _context.Trainees.ToListAsync();
            return Ok(trainees);
        }

        [HttpGet("Trainees/{id}")]
        public async Task<IActionResult> GetTrainee(int id)
        {
            var trainee = await _context.Trainees.FindAsync(id);
            if (trainee == null)
            {
                return NotFound();
            }
            return Ok(trainee);
        }

        [HttpPost("Trainees")]
        public async Task<IActionResult> CreateTrainee([FromBody] Trainee trainee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Trainees.Add(trainee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTrainee), new { id = trainee.Id }, trainee);
        }

        [HttpPut("Trainees/{id}")]
        public async Task<IActionResult> UpdateTrainee(int id, [FromBody] Trainee trainee)
        {
            if (id != trainee.Id)
            {
                return BadRequest();
            }

            _context.Entry(trainee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TraineeExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        [HttpDelete("Trainees/{id}")]
        public async Task<IActionResult> DeleteTrainee(int id)
        {
            var trainee = await _context.Trainees.FindAsync(id);
            if (trainee == null)
            {
                return NotFound();
            }

            _context.Trainees.Remove(trainee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TraineeExists(int id)
        {
            return _context.Trainees.Any(e => e.Id == id);
        }

        #endregion

        #region User CRUD

        [HttpGet("Users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }

        [HttpGet("Users/{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost("Users")]
        public async Task<IActionResult> CreateUser([FromBody] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpPut("Users/{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        [HttpDelete("Users/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        #endregion
    }
}
