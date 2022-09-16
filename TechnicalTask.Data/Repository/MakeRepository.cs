﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class MakeRepository : IRepository<Make>
    {
        ApplicationDbContext _dbContext;
        public MakeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Make> Create(Make _object)
        {
            var obj = await _dbContext.Makes.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public IEnumerable<Make> GetAll()
        {
            try
            {
                return _dbContext.Makes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Make make)
        {
            try
            {
                _dbContext.Makes.Remove(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Make GetById(int id)
        {
            try
            {
                return _dbContext.Makes.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(Make make)
        {
            try
            {
                _dbContext.Makes.Update(make);
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
