using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class User
    {
        public string Username { get; set; }
        public string Password
        { 
            private get
            { 
                return _password;
            }
            set 
            {
                if (value.Length < 8) return;
                else if (string.IsNullOrWhiteSpace(value)) return;
                else if (!ContainsOneUpperCaseLetter(value)) return;
                else if (!ContainsDigit(value)) return;
                _password = value;
            }
        }

        private int _age;
        private string _password;

        public int Age 
        { 
            get 
            { 
                return _age;
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Age menfi ola bilmez");
                    return;
                }
                _age = value;
            } 
        }

        private bool ContainsOneUpperCaseLetter(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c)) return true;
            }
            return false;
        }

        private bool ContainsDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
