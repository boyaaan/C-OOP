﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Factories
{
    using Products;
    using System.Linq;
    using System.Reflection;

    public class ProductFactory
    {
        public Product CreatProduct(string type, double price)
        {
            var productType = this.GetType()
                .Assembly
                .GetTypes()
                .FirstOrDefault(t => typeof(Product).IsAssignableFrom(t) && !t.IsAbstract && t.Name == type);

            if (productType == null)
            {
                throw new InvalidOperationException("Invalid product type!");
            }

            try
            {
                var product = (Product)Activator.CreateInstance(productType, price);
                return product;
            }
            catch (TargetInvocationException e)
            {
                throw e.InnerException;
            }
        }
    }
}
