using Models.Commands;
using Models.Entities;
using Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Services
{
    public class PersonneService : IPersonneRepository
    {
        private IList<Personne> _items;

        public PersonneService() 
        {
            _items = new List<Personne>();
        }

        public IEnumerable<Personne> Get()
        {
            return _items;
        }

        public Personne? Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Personne personne)
        {
            AddPersonCommand command = new AddPersonCommand(_items, personne);
            command.Execute();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
