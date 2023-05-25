namespace LoggerDb
{
    public interface ILogDb<T>
    {
        void Create(T dataFlight);
    }
}
