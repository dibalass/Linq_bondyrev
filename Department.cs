using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Department
    {
        string name, reg;
        public string Name { get { return name; } set { name = value; } }
        public string Reg { get { return reg; } set { reg = value; } }
        public Department(string name_, string reg_)
        {
            Name = name_;
            Reg = reg_;
        }
        public override string ToString()
        {
            return $"{Name} {Reg}";
        }
    }
}
