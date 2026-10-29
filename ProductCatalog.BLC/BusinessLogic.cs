using System;
using System.Linq;
using System.Reflection;
using Interfaces;

namespace ProductCatalog.BLC
{
    // Sealed class ensures it cannot be inherited (Singleton requirement)
    public sealed class BusinessLogic
    {
        // Private static field to hold the single instance
        private static BusinessLogic _instance;

        // Property to expose the dynamically loaded database
        public IDAO Database { get; private set; }

        // Private constructor taking the library path
        private BusinessLogic(string libraryPath)
        {
            // Dynamically load the library
            Assembly assembly = Assembly.UnsafeLoadFrom(libraryPath);

            // Find the first class that implements IDAO
            Type daoType = assembly.GetTypes()
                .FirstOrDefault(type => typeof(IDAO).IsAssignableFrom(type) && !type.IsInterface);

            if (daoType != null)
            {
                // Create an instance of the found DAO class
                Database = (IDAO)Activator.CreateInstance(daoType);
            }
            else
            {
                throw new Exception("IDAO implementation not found.");
            }
        }

        // Public static method to retrieve the instance
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