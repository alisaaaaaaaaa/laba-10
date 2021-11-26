using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_10_
{
    class Student
    {
        public string Name;
        public string GroupNumber;
        public void GetName(string Name)
        {
            this.Name = Name;
        }
        public void GetGroupNumber(string GroupNumber)
        {
            this.GroupNumber = GroupNumber;
        }
        public void Print()
        {
            Console.WriteLine($"имя студента:{Name}");
            Console.WriteLine($"группа студента:{GroupNumber}");
        }
    }
}
