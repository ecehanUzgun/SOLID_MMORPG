﻿namespace BusinessLogic.Services.Abstracts
{
    public abstract class ControlBaseService<TEntity>
    {
        public abstract void ControlEntity(ref int userEntity, List<TEntity> entities);
    }
}
