using RefineModels.Models;
using RefineModels.Models.ASR;
using System;
using System.Collections.Generic;

namespace Refine.Repositories.IRepository
{
    public interface IRepository<T> where T : class
    {


        void UpdateEntity(object entity, UpdateItemDto updateItem);
        object ConvertToNullable(string value, Type underlyingType);
        T GetEntityById<T>(int? UpdatedItemID) where T : class;
        public List<T> GetEntities<T>() where T : class;
        //List<AsrBase> CombineAsrLists<T>(params IEnumerable<T>[] lists) where T : AsrBase;

    }
}
