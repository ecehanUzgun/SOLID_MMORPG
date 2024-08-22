namespace BusinessLogic.Services.Abstracts
{
    public abstract class GenericBaseService<TEntity>
    {
        public abstract List<TEntity> ListEntity();
    }
}
