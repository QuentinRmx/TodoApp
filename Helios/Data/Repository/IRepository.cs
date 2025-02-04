﻿using Helios.Data.Models;

namespace Helios.Data.Repository
{
    internal interface IRepository<TModel> where TModel : Model
    {
        Task InitConnection();

        Task<ERepositoryResponse> Add(TModel row);

        Task<ERepositoryResponse> Update(TModel row);

        Task<ERepositoryResponse> Delete(TModel row);

        Task<List<TModel>> GetAll();
    }
}
