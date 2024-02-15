using Models.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Repositories
{
    public interface IPersonneRepository
    {
        IEnumerable<Personne> Get();
        Personne? Get(int id);
        void Insert(Personne personne);
        void Delete(int id);
    }
}
