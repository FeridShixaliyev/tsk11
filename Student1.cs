using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class Student
    {
        public string FullName { get; set; }
        public int NO { get; private set; }
        
        public Student()
        {
            NO++;
        }
             
    }
}
