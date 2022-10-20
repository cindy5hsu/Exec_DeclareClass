using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
             class Address
        {
            // prop
            public string City { get; set; }

            //public string City { get; set; }
            public string ZipCode { get; set; }
            public string Street { get; set; }
        }
        class Telephone
        {
            public string CountryCode { get; set; }
            public string AreaCode { get; set; }
            public string Number { get; set; }

            public string Ext { get; set; }
        }

        class Member
        {
            public string Name { get; set; }

            public string Account { get; set; }
            public string Email { get; set; }
            public string password { get; set; }
            public Address Addr { get; set; }
            public string Cellphone { get; set; }
            public Telephone Telephone { get; set; }

            public void Register(string Name, string Account,
                                string Password, string confirmPassword,
                                 string Email)
            {

            }


            public void ForgetPassword(string name, string email)
            {

            }

            public void Aunthenticate(string Account, string Password)
            {

            }

        }
    }
}
