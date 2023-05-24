namespace POS.Infrastructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //Declaración o matricula de nuestra interface a nivel repositorio
        ICategoryRepository Category { get; }

        void SaveChanges();
        Task SaveChangesAsync();
    }
}