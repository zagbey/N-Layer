namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //bunu implemente ettiğimiz zaman DbContextin savechanges() ve savechangesasync metodunu çağırıyor olucaz
        Task CommitAsync();
        void Commit();
    }
}
