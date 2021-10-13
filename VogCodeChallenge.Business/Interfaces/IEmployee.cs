using System.Collections.Generic;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Business.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();

    }
}
