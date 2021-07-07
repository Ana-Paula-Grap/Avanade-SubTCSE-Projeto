using Avanada.SubTCSE.Projeto.Domain.Aggregates;
using System.Threading.Tasks;

namespace Avanada.SubTCSE.Projeto.Domain.Base.Repository
{
    public interface IBaseRepository<TEntity, Tid>
        where TEntity : BaseEntity<Tid>
    {
        Task<TEntity> Add(TEntity entity);

        Task<TEntity> FindById(Tid Id);
    }
}
