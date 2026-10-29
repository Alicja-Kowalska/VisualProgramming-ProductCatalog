using System;
using System.Linq;
using System.Reflection;
using Interfaces;

namespace ProductCatalog.BLC
{
    public sealed class BusinessLogic
    {
        private static BusinessLogic _instance;

        public IDAO Database { get; private set; }

        private BusinessLogic(string libraryPath)
        {
            Assembly assembly = Assembly.UnsafeLoadFrom(libraryPath);

            Type daoType = assembly.GetTypes()
                .FirstOrDefault(type => typeof(IDAO).IsAssignableFrom(type) && !type.IsInterface);

            if (daoType != null)
            {
                Database = (IDAO)Activator.CreateInstance(daoType);
            }
            else
            {
                throw new Exception("IDAO implementation not found.");
            }
        }

        public static BusinessLogic GetInstance(string libraryPath)
        {
            if (_instance == null)
            {
                _instance = new BusinessLogic(libraryPath);
            }
            return _instance;
        }
    }
}