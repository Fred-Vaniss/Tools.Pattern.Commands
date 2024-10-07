using Models.Entities;
using Tools.Pattern.Commands;

namespace Models.Commands;

public class DeletePersonCommand : ICommand
{
    private readonly IList<Personne> _list;
    private readonly int _id;

    public DeletePersonCommand(IList<Personne> list, int id)
    {
        _list = list;
        _id = id;
    }

    public void Execute()
    {
        var personne = _list.FirstOrDefault(p => p.Id == _id);

        if (personne is not null)
            _list.Remove(personne);
        else
            throw new KeyNotFoundException($"Person with Id {_id} not found");
    }
}