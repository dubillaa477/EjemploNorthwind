using EjemploNorthwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthind.Logic
{
    public interface IClientLogic
    {
        List<Client> GetClients();
        List<Client> GetClients(string nameFilter);
        Client GetById(int id);
    }
}
