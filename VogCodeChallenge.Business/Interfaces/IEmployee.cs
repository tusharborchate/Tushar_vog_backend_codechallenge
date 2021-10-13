using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Business.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();

    }
}
