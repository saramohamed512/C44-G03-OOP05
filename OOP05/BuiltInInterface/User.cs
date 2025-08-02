using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.BuiltInInterface
{
    internal class User : ICloneable
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
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
