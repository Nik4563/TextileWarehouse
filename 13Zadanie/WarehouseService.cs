using System;
using System.Collections.Generic;
using System.Text;

namespace _13Zadanie
{
    class WarehouseService
    {
        private Dictionary<Guid, Product> _products;

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Пустое значение");
            }

            if (_products.ContainsKey(product.Id))
            {
                throw new ArgumentException("Продукт с таким ID уже существует", nameof(product));
            }

            _products.Add(product.Id, product);
        }
    }
}
