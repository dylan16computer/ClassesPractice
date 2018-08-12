using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonClass
{
    class Person
    {
        string firstName;
        string lastName;
        int age;
        string address;
        int phone;
        string GetFirstName()
        {
            return firstName;
        }
        string GetLastName()
        {
            return lastName;
        }
        int GetAge()
        {
            return age;
        }
        string GetAddress()
        {
            return address;
        }
        int GetPhone()
        {
            return phone;
        }
        public string GetDetails()
        {
            return $"First Name: {GetFirstName()}\nLast Name: {GetLastName()}\nAge: {GetAge()}\nAddress: {GetAddress()}\nPhone: {GetPhone()}";
        }

        public Person(string fname, string lname, int _age, string add, int _phone)
        {
            firstName = fname;
            lastName = lname;
            age = _age;
            address = add;
            phone = _phone;
        }
    }
}
