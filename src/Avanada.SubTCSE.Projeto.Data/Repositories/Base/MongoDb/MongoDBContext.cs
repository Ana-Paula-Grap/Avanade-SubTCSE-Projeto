using Avanada.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanada.SubTCSE.Projeto.Data.Repositories.Base.MongoDb
{
    public class MongoDBContext : IMongoDBContext
    {
        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
            throw new System.NotImplementedException();
        }
    }
}
