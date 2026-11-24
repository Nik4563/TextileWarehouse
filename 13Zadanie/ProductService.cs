using System;
using System.Collections.Generic;
using System.Text;

namespace _13Zadanie
{
    class ProductService
    {
        public static void AddStock(Product product, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Количество не может быть отрицательным, либо нулевым");
            }

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Нет продукта у которого нужно увеличить количество");
            }
            product.Quantity += quantity;
        }

        public static void RemoveStock(Product product, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Некорректное количество");
            }

            if (product == null)
            {
                throw new ArgumentNullException(nameof(product), "Нет продукта у которого нужно уменьшить количество");
            }

            if (product.Quantity < quantity)
            {
                throw new ArgumentException("Недостаточно товара");
            }

            product.Quantity -= quantity;
        }
    }
}
