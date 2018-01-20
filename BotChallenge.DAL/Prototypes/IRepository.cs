
namespace BotChallenge.DAL.Prototypes
{
    public interface IRepository<T>
    {
        T Get(string id);
        void Add(T item);
        void Update(T item);
        void Delete(string id);
    }
}
