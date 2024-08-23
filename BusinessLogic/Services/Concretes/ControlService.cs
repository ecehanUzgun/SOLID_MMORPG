using BusinessLogic.Services.Abstracts;
using DataAccess.Entities;

namespace BusinessLogic.Services.Concretes
{
    public class ControlService<TEntity> : ControlBaseService<TEntity> where TEntity : class
    {
        public override void ControlEntity(int userEntity, List<TEntity> entities)
        {
            while (userEntity == 0)
            {
                try
                {
                    userEntity = int.Parse(Console.ReadLine());
                    if (userEntity > 0 && userEntity <= entities.Count)
                    {
                        Console.WriteLine($"{userEntity} seçtiniz");
                    }
                    else
                    {
                        Console.WriteLine("Lütfen listedekilerden birini seçin.\n");
                        userEntity = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
