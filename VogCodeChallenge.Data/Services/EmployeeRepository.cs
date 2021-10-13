using System;
using System.Collections.Generic;
using VogCodeChallenge.Data.Interfaces;
using VogCodeChallenge.Entities.Models;
using System.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace VogCodeChallenge.Business.Services
{
    public class EmployeeRepository : IRepository
    {
        protected DbContext _context;
        protected DbSet<Employee> dbSet;

        public EmployeeRepository(DbContext context)
        {
            _context = context;
            dbSet = _context.Set<Employee>();
        }
        public IEnumerable<Employee> GetAll()
        {
            try
            {
               return dbSet.ToList();
            }
            catch (Exception ex)
            {
                // we can log the exception
                throw;
            }
        }
        //this will take departmentid as paramter and queryable
        public IList<Employee> ListAll()
        {
            try
            {
                return dbSet.AsQueryable().Where(a=>a.DepartmentId== 1).ToList();
            }
            catch (Exception ex)
            {
                // we can log the exception
                throw;
            }
        }
        
    }
}
