﻿using System.Collections.Generic;
using SAOnlineMart.Models;

namespace SAOnlineMart.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}