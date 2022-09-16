using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Service.Interface
{
    public interface IMake
    {
        public Task<Make> AddMake(Make make);
        public IEnumerable<Make> GetMakes();
        public void Delete(int id);
        public Make GetById(int id);
        public void Update(Make make);
    }
}
