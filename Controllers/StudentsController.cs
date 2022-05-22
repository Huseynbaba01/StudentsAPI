using Microsoft.AspNetCore.Mvc;
using StudentsBackend.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentsBackend.Controllers
{
    [Route("StudentsAPI")]
    public class StudentsController : Controller
    {
        private readonly MPDContext db = new();

        [Route("AddNewStudent")]
        [HttpPost]
        public bool AddNewStudent(string NAME, string SURNAME, string DEGREE)
        {
            db.Students.Add(new Student { Degree = DEGREE, Name = NAME, Surname = SURNAME });
            db.SaveChanges();
            return true;
        }

        [Route("AddNewUser")]
        [HttpPost]
        public bool AddNewUser(string USERNAME, string PASSWORD)
        {
            db.Users.Add(new User { Password = PASSWORD, Username = USERNAME });
            db.SaveChanges();
            return true;
        }

        [Route("CheckUser")]
        [HttpGet]
        public bool checkUser(string username, string password)
        {
             var user = from u in db.Users
             where u.Username == username && u.Password == password
                         select u;
            return user.Count() == 1;
        }

        [Route("GetStudents")]
        [HttpGet]
        public List<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        [Route("GetUsers")]
        [HttpGet]
        public List<User> GetAllUsers()
        {
            return db.Users.ToList();
        }
    }
}
