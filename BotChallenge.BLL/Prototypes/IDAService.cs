using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotChallenge.BLL.Prototypes
{
    public interface IDAService<T>
    {
        T Get(int id);
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
