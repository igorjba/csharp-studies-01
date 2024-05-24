using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto17Exercicio06
{
    internal class Student
    {

        private static int nextId = 1;

        public Student()
        {
            StudentId = nextId++;
        }

        public int StudentId { get; private set; }
        public string FirstName { get; set; }
        public string Email { get; set; }

    }
}
