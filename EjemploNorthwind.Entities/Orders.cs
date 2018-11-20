using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthwind.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public List<OrderLine> Line { get; set; }
        public Employee employee { get; set; }
    }
}
