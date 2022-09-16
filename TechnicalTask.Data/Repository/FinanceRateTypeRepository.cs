using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class FinanceRateTypeRepository : IRepository<FinanceRateType>
    {
        ApplicationDbContext _dbContext;
        public FinanceRateTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<FinanceRateType> Create(FinanceRateType _object)
        {
            var obj = await _dbContext.FinanceRateTypes.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public IEnumerable<FinanceRateType> GetAll()
        {
            try
            {
                return _dbContext.FinanceRateTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(FinanceRateType make)
        {
            try
            {
                _dbContext.FinanceRateTypes.Remove(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public FinanceRateType GetById(int id)
        {
            try
            {
                return _dbContext.FinanceRateTypes.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(FinanceRateType make)
        {
            try
            {
                _dbContext.FinanceRateTypes.Update(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
