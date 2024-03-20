﻿using APISolution.Domain;
using System.Collections.Generic;

namespace APISolution.Data.Interfaces.Data
{
    public interface ICategoryData : ICrud<Category>
    {
        Task <IEnumerable<Category>> GetByName(string name);
        Task <IEnumerable<Category>> GetWithPaging(int pageNumber, int pageSize, string name);
        Task <int> GetCountCategories(string name);
        Task <int> InsertWithIdentity(Category category);
    }
}
