using DataAccess.Data;
using Refine.Repositories.IRepository;
using RefineModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Refine.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public object ConvertToNullable(string value, Type underlyingType)
        {
            return string.IsNullOrEmpty(value) ? null : Convert.ChangeType(value, underlyingType);
        }

        public T GetEntityById<T>(int? UpdatedItemID) where T : class
        {
            return _db.Set<T>().Find(UpdatedItemID);
        }

        public List<T> GetEntities<T>() where T : class
        {
            return _db.Set<T>().ToList();
        }

        public void UpdateEntity(object entity, UpdateItemDto updateItem)
        {
            var property = entity.GetType().GetProperty(updateItem.Field);

            if (property != null)
            {
                if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    // Handle nullable types
                    var underlyingType = Nullable.GetUnderlyingType(property.PropertyType);
                    var convertedValue = ConvertToNullable(updateItem.Value, underlyingType);
                    property.SetValue(entity, convertedValue);
                }
                else
                {
                    // Handle non-nullable types
                    var convertedValue = Convert.ChangeType(updateItem.Value, property.PropertyType);
                    property.SetValue(entity, convertedValue);
                }

                _db.SaveChanges();
            }
        }
    }
}
