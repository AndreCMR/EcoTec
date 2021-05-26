namespace EcoTec.Domain.Interface.Crud
{
    public interface IAdd<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
    }
}