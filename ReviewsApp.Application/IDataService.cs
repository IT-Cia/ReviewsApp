namespace ReviewsApp.Application
{
    public interface IDataService<T>
    {
        List<T> Get();
        T GetById(int id);
        List<T> GetLast(int count);
        List<T> GetNext(int count, List<T> previousItems);
        void Add(T item);
        void Delete(int id);
    }
}
