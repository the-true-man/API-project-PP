using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace project_PP
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string lastName { get; set; }
        public string middleName { get; set; } = "";
        public string email { get; set; }
        public string password { get; set; }
        public bool isGuest {  get; set; } = false;
        private static int _uniqID = 1;
        public List<Order> orders = new List<Order>();

        public Person(string name, string lastname, string middlename, string email, string password)
        {
            Id = _uniqID;
            _uniqID++;
            Name = name;
            lastName = lastname;
            middleName = middlename;
            this.email = email;
            this.password = password;
        }
        public bool validateFields(List<Person> persons)
        {
            const string regexValidateEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            const string regexValidatePassword = @"^(?=.*[a-zA-Z])(?=.*\d).{6,15}$";
            const string regexValidateField = @"^[а-яА-Я]+$|^[a-zA-Z]+$";

            Person emailPerson = persons.FirstOrDefault(p => p.email == email);
            if (emailPerson != null)
            {
                return false;
            }

            if (!Regex.IsMatch(email, regexValidateEmail))
            {
                return false;
            }
            if (!Regex.IsMatch(password, regexValidatePassword))
            {
                return false;
            }
            if (!Regex.IsMatch(Name, regexValidateField) || !Regex.IsMatch(lastName, regexValidateField) || !Regex.IsMatch(middleName, regexValidateField))
            {
                return false;
            }
            return true;
        }
    }
}
