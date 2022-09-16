﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class VehicleTypeRepository : IRepository<VehicleType>
    {
        ApplicationDbContext _dbContext;
        public VehicleTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<VehicleType> Create(VehicleType _object)
        {
            var obj = await _dbContext.VehicleTypes.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public IEnumerable<VehicleType> GetAll()
        {
            try
            {
                return _dbContext.VehicleTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(VehicleType make)
        {
            try
            {
                _dbContext.VehicleTypes.Remove(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public VehicleType GetById(int id)
        {
            try
            {
                return _dbContext.VehicleTypes.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(VehicleType make)
        {
            try
            {
                _dbContext.VehicleTypes.Update(make);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
