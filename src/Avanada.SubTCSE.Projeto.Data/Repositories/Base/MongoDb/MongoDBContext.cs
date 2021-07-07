using Avanada.SubTCSE.Projeto.Domain.Base.Repository.MongoDB;
using MongoDB.Driver;

namespace Avanada.SubTCSE.Projeto.Data.Repositories.Base.MongoDb
{
    public class MongoDBContext : IMongoDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;

        public MongoDBContext()
        {
            MongoClientSettings mongoClientSettings = MongoClientSettings
                .FromUrl(new MongoUrl(""));

            mongoClientSettings.SslSettings = new SslSettings()
            {
                EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
            };

            MongoClient mongoClient = new MongoClient(settings: mongoClientSettings);

            _mongoDatabase = mongoClient.GetDatabase("");


        }

        public IMongoCollection<TEntity> GetCollection<TEntity>(string collection)
        {
           return _mongoDatabase.GetCollection<TEntity>(name: collection);
        }
    }
}
