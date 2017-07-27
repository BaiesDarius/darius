using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAnimalRepository : IDisposable
    {
        void Add(Animal animal);

        void Update(Animal animal);

        void Delete(Animal animal);

        Animal Get(string name);

        void Save();
    }
}
