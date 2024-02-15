
using Models.Entities;
using Tools.Pattern.Commands;

namespace Models.Commands
{
    public class AddPersonCommand : ICommand
    {
        private readonly IList<Personne> _list;
        private readonly Personne _personne;

        public AddPersonCommand(IList<Personne> list, Personne personne) 
        {
            _list = list;
            _personne = personne;
        }

        public void Execute()
        {
            _personne.Id = _list.Count == 0 ? 1 : _list.Max(p => p.Id) + 1; ;
            _list.Add(_personne);
        }
    }
}
