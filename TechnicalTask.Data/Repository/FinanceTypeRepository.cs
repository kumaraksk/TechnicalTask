﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class FinanceTypeRepository : IRepository<FinanceType>
    {
        ApplicationDbContext _dbContext;
        public FinanceTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<FinanceType> Create(FinanceType _object)
        {
            var obj = await _dbContext.FinanceTypes.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public IEnumerable<FinanceType> GetAll()
        {
            try
            {
                return _dbContext.FinanceTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(FinanceType make)
        {
            try
            {
                _dbContext.FinanceTypes.Remove(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FinanceType GetById(int id)
        {
            try
            {
                return _dbContext.FinanceTypes.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(FinanceType make)
        {
            try
            {
                _dbContext.FinanceTypes.Update(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
