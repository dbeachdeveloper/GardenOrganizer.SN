using Business.DatabaseModels;
using Business.Models;
using Business.Services;
using FatHead.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class SeedTypeDbService : ISeedTypeService
    {
        private readonly IModelConverter _modelConverter;
        private IList<SeedType> _seedTypes;
        private IList<DbSeedType> _dbSeedTypes;

        /// <summary>
        /// SeedTypeTestService Constructor
        /// </summary>
        /// <param name="modelConverter">IModelConverter Converts database models into display models</param>
        public SeedTypeDbService(IModelConverter modelConverter)
        {
            _seedTypes = new List<SeedType>();
            _dbSeedTypes = new List<DbSeedType>();
            _modelConverter = modelConverter;
        }

        public Task<int> Delete(SeedType seedType)
        {
            throw new System.NotImplementedException();
        }

        public Task<SeedType> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<SeedType>> GetList()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Post(SeedType seedType)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Put(SeedType seedType)
        {
            throw new System.NotImplementedException();
        }
    }
}
