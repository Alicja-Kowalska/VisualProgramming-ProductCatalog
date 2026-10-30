using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Interfaces;

namespace ProductCatalog.BLC
{
    public sealed class BusinessLogic : IDAO
    {
        private static BusinessLogic? _instance;
        private IDAO _database;

        private BusinessLogic(string libraryPath)
        {
            Assembly assembly = Assembly.UnsafeLoadFrom(libraryPath);
            Type? daoType = assembly.GetTypes()
                .FirstOrDefault(type => typeof(IDAO).IsAssignableFrom(type) && !type.IsInterface);

            if (daoType != null)
            {
                _database = (IDAO)Activator.CreateInstance(daoType)!;
            }
            else
            {
                throw new Exception("IDAO implementation not found.");
            }
        }

        public static BusinessLogic GetInstance(string libraryPath)
        {
            _instance ??= new BusinessLogic(libraryPath);
            return _instance;
        }

        public IEnumerable<IKennelClub> GetAllClubs()
        {
            return _database.GetAllClubs();
        }

        public IEnumerable<IDogBreed> GetAllBreeds()
        {
            return _database.GetAllBreeds();
        }
    }
}