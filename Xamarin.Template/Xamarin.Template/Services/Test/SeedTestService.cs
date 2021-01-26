using Business.DatabaseModels;
using Business.Models;
using Business.Services;
using FatHead.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class SeedTestService : ISeedService
    {
        private readonly IModelConverter _modelConverter;
        private IList<Seed> _seeds;
        private IList<DbSeed> _dbSeeds;

        /// <summary>
        /// SeedTypeTestService Constructor
        /// </summary>
        /// <param name="modelConverter">IModelConverter Converts database models into display models</param>
        public SeedTestService(IModelConverter modelConverter)
        {
            _seeds = new List<Seed>();
            _dbSeeds = new List<DbSeed>();
            _modelConverter = modelConverter;
        }

        public Task<int> Delete(Seed seedType)
        {
            throw new NotImplementedException();
        }

        public Task<Seed> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Seed>> GetList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns a manually populated list of Seed to simulate getting the list form a database or api call.
        /// </summary>
        /// <returns>IList of Seed</returns>
        public async Task<IList<Seed>> GetList(string type)
        {
            if (_seeds.Count == 0)
            {
                _dbSeeds = await LoadDefaultSeeds();

                _seeds = _modelConverter.ConvertModelListFromModelList<DbSeed, Seed>(_dbSeeds);
            }

            return _seeds.Where(x => x.Type == type).ToList();
        }

        public Task<int> Post(Seed seedType)
        {
            throw new NotImplementedException();
        }

        public Task<int> Put(Seed seedType)
        {
            throw new NotImplementedException();
        }

        private async Task<IList<DbSeed>> LoadDefaultSeeds()
        {
            IList<DbSeed> temp = new List<DbSeed>();
            DbSeed dbSeed = new DbSeed();

            await Task.Run(() =>
            {
                temp.Add(
                    new DbSeed()
                    {
                        Type = "Tomato",
                        Variety = "Roma",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new DbSeed()
                    {
                        Type = "Tomato",
                        Variety = "Cherry",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new DbSeed()
                    {
                        Type = "Tomato",
                        Variety = "Big Boy",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new DbSeed()
                    {
                        Type = "Pumpkin",
                        Variety = "Sugar",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new DbSeed()
                    {
                        Type = "Pepper",
                        Variety = "Jalapeno",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });

                temp.Add(
                    new DbSeed()
                    {
                        Type = "Pepper",
                        Variety = "Bell",
                        Manufacturer = "Baker Creek",
                        MinSproutInDays = 7,
                        MaxSproutInDays = 14,
                        MinTemperature = 50,
                        MaxTemperature = 90,
                        MinSun = 4,
                        MaxSun = 8,
                        FrostHardy = false,
                        PurchaseDate = DateTime.Now,
                        SeedDepth = "1 inch",
                        PlantSpacing = "12 inches"
                    });
            });

            return temp;
        }
    }
}
