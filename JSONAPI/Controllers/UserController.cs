using JSONAPI.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;
using project_PP;
using System.Text.RegularExpressions;
using System.Windows;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JSONAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        [HttpGet("allUsers")]
        public ActionResult<Person> GetAllUsers()
        {
            var users = JSON_User.getUsers();
            if(users == null || users.Count == 0)
            {
                return NotFound("Пользователи не найдены");
            }
            return Ok(users);
        }

        [HttpGet("{id}")]
        public ActionResult<Person> UserId(int id)
        {
            var users = JSON_User.getUsers();
            var user =  users.FirstOrDefault(u => u.Id == id);
            return user == null ? NotFound("Пользователь не найден") : Ok(user);
        }

        [HttpPost]
        public ActionResult<Person> UserId(string email, string password)
        {
            var users = JSON_User.getUsers();
            var user = users.FirstOrDefault(u => u.email == email && u.password == password);
            return user == null ? NotFound("Пользователь не найден") : Ok(user);
        }

        [HttpPost("Registration")]
        public ActionResult<Person> Register(Person person)
        {
            List<Person> persons = JSON_User.getUsers();
            person.Id = persons.Max(u => u.Id) + 1;
            if(person.validateFields(persons))
            {
                persons.Add(person);
                JSON_User.setUser(persons);
                return Ok("Успешная регистрация");
            }
            else
            {
                return BadRequest("Ошибка регистрации");
            }

        }

        [HttpPost("Auth")]
        public ActionResult<Person> Auth([FromBody] LoginRequest loginRequest)
        {
            var user_check = JSON_User.getUsers().FirstOrDefault(u => u.email == loginRequest.Email && u.password == loginRequest.Password);
            return user_check == null ? NotFound("Пользователь не найден") : Ok(user_check);


        }

        [HttpDelete("DeleteUser{id}")]
        public ActionResult<Person> deleteUser(int id)
        {
            List<Person> users = JSON_User.getUsers() ?? new List<Person>();
            var user_id = users.FirstOrDefault(u => u.Id == id);
            if (user_id == null)
            {
                return NotFound("Пользователь не найден.");
            }
            users.Remove(user_id);
            MessageBox.Show(users.Count.ToString());
            string newJson = JsonConvert.SerializeObject(users, Formatting.Indented); 
            System.IO.File.WriteAllText(JSON_User.pathUsers, newJson);
            return CreatedAtAction(nameof(Register), "Ваш профиль удален!");

        }


    }
}
