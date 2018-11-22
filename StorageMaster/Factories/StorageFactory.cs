﻿using System;


namespace StorageMaster.Factories
{
    using Storage;
    using System.Linq;
    using System.Reflection;

    public class StorageFactory
    {
        public Storage CreateStorage(string type, string name)
        {
            var storageType = this.GetType()
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => typeof(Storage).IsAssignableFrom(t) && !t.IsAbstract && t.Name == type);

            if (storageType == null)
            {
                throw new InvalidOperationException("Invalid storage type!");
            }

            try
            {
                var storage = (Storage)Activator.CreateInstance(storageType, name);
                return storage;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}
