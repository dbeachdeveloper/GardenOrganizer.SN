using Business.DatabaseModels;
using Business.Models;
using Business.Services;
using FatHead.Converters;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class SeedTypeTestService : ISeedTypeService
    {
        private readonly IModelConverter _modelConverter;
        private IList<SeedType> _seedTypes;
        private IList<DbSeedType> _dbSeedTypes;

        /// <summary>
        /// SeedTypeTestService Constructor
        /// </summary>
        /// <param name="modelConverter">IModelConverter Converts database models into display models</param>
        public SeedTypeTestService(IModelConverter modelConverter)
        {
            _seedTypes = new List<SeedType>();
            _dbSeedTypes = new List<DbSeedType>();
            _modelConverter = modelConverter;
        }

        /// <summary>
        /// Returns a manually populated list of SeedType to simulate getting the list form a database or api call.
        /// </summary>
        /// <returns>IList of SeedType</returns>
        public async Task<IList<SeedType>> GetList()
        {
            if (_seedTypes.Count == 0)
            {
                _dbSeedTypes = await LoadDefaultSeedTypes();

                _seedTypes = _modelConverter.ConvertModelListFromModelList<DbSeedType, SeedType>(_dbSeedTypes);
            }
           
            return _seedTypes.OrderBy(x => x.Type).ToList();
        }

        public async Task<int> Delete(SeedType seedType)
        {
            DbSeedType temp = new DbSeedType();

            _modelConverter.ConvertModelFromModel(seedType, temp);

            await Task.Run(() =>
            {
                //Send the DbSeedType to the database or api async    
            });

            _seedTypes.Remove(seedType);

            return 1;
        }

        public async Task<SeedType> Get(int id)
        {
            SeedType temp = _seedTypes.Where(x => x.Id == id).FirstOrDefault();

            await Task.Run(() =>
            {
                //Retrieve the SeedType by id from the database or api async  
            });

            return temp;
        }

        public async Task<int> Put(SeedType seedType)
        {
            DbSeedType temp = new DbSeedType();

            _modelConverter.ConvertModelFromModel(seedType, temp);

            await Task.Run(() =>
            {
                //Post the DbSeedType to the database or api async    
            });

            foreach (SeedType s in _seedTypes)
            {
                if (s.Id == seedType.Id)
                {
                    s.Type = seedType.Type;
                }
            }

            return 1;
        }

        public async Task<int> Post(SeedType seedType)
        {
            DbSeedType temp = new DbSeedType();

            _modelConverter.ConvertModelFromModel(seedType, temp);

            await Task.Run(() =>
            {
                //Put the DbSeedType to the database or api async    
            });

            seedType.Id = _seedTypes.Count + 1;

            _seedTypes.Add(seedType);

            return 1;
        }

        private async Task<IList<DbSeedType>> LoadDefaultSeedTypes()
        {
            IList<DbSeedType> temp = new List<DbSeedType>();

            await Task.Run(() =>
            {
                temp = new List<DbSeedType>()
                {
                    new DbSeedType(){ Id = 1, Type = "Asparagus"},
                    new DbSeedType(){ Id = 2, Type = "Bean"},
                    new DbSeedType(){ Id = 3, Type = "Beet"},
                    new DbSeedType(){ Id = 4, Type = "Chard"},
                    new DbSeedType(){ Id = 5, Type = "Broccoli"},
                    new DbSeedType(){ Id = 6, Type = "Brussels Sprouts"},
                    new DbSeedType(){ Id = 7, Type = "Cabbage"},
                    new DbSeedType(){ Id = 8, Type = "Capsicum"},
                    new DbSeedType(){ Id = 9, Type = "Carrot"},
                    new DbSeedType(){ Id = 10, Type = "Cauliflower"},
                    new DbSeedType(){ Id = 11, Type = "Celeriac"},
                    new DbSeedType(){ Id = 12, Type = "Celery"},
                    new DbSeedType(){ Id = 13, Type = "Chickpea"},
                    new DbSeedType(){ Id = 14, Type = "Corn"},
                    new DbSeedType(){ Id = 15, Type = "Cucumber"},
                    new DbSeedType(){ Id = 16, Type = "Eggplant"},
                    new DbSeedType(){ Id = 17, Type = "Lettuce"},
                    new DbSeedType(){ Id = 18, Type = "Onion"},
                    new DbSeedType(){ Id = 19, Type = "Parsnip"},
                    new DbSeedType(){ Id = 20, Type = "Peas"},
                    new DbSeedType(){ Id = 21, Type = "Potato"},
                    new DbSeedType(){ Id = 22, Type = "Pumpkin"},
                    new DbSeedType(){ Id = 23, Type = "Radish"},
                    new DbSeedType(){ Id = 24, Type = "Spinach"},
                    new DbSeedType(){ Id = 25, Type = "Squash"},
                    new DbSeedType(){ Id = 26, Type = "Tomato"},
                    new DbSeedType(){ Id = 27, Type = "Turnip"},
                    new DbSeedType(){ Id = 28, Type = "Zucchini"},
                    new DbSeedType(){ Id = 29, Type = "Pepper"},
                    new DbSeedType(){ Id = 30, Type = "View All"}
                };
            });

            return temp;
        }
    }
}
