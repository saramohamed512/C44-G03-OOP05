using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.BuiltInInterface
{
    internal class User : ICloneable, IComparable<User>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public object Clone()
        {
           return new User
            {
                Id = this.Id,
                Name = this.Name,
                Salary = this.Salary
            };
        }

        public int CompareTo(User? other)
        {
            //+ve =1 this.salary > obj.salary
            //-ve =-1 this.salary < obj.salary
            //0 =0 this.salary == obj.salary
            if (this.Salary > other?.Salary)
            {
                return 1;
            }
            else if (this.Salary < other?.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

      

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }

    }
}
