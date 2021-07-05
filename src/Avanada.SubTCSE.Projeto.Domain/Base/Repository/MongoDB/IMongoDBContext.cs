using MongoDB.Driver;

namespace Avanada.SubTCSE.Projeto.Domain.Base.Repository.MongoDB
{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
