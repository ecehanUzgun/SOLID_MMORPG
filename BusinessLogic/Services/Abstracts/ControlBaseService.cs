namespace BusinessLogic.Services.Abstracts
{
    public abstract class ControlBaseService<TEntity>
    {
        public abstract void ControlEntity(int userEntity, List<TEntity> entities);
    }
}
