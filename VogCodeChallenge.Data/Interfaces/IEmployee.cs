using System.Collections.Generic;
using VogCodeChallenge.Entities.Models;

namespace VogCodeChallenge.Data.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Employee> GetAll();
        IList<Employee> ListAll();

    }
}
