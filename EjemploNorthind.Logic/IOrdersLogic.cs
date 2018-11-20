using EjemploNorthwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthind.Logic
{
    interface IOrdersLogic
    {
        Orders GetById(int Id);
        OrderLine EditLine(int LineId, int Quantity);   

    }
}
