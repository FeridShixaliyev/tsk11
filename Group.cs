using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    enum Type
    {
        Programming, 
        Design,
        System
    }
    class Group
    {
        public string No { get; set; }
        public int _no=100;
        Student[] students;
        public Type type { get; set; }

        public Group()
        {
            _no++;    
        }
        

        
    }
}
