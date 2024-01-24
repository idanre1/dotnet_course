using System.Diagnostics.CodeAnalysis; // for using NotNullWhen

namespace EliminateWarnings;

public class CharacterRepository
{
//!1!    private Dictionary<string, Person> _map;
    private Dictionary<string, Person> _map = new();

    public void Add(Person person)
    {
//!1!        _map ??= new();

        _map[person.ToString()] = person;
    }

    //public bool TryGetPerson(string name, out Person person)
    public bool TryGetPerson(string name, [NotNullWhen(true)] out Person? person)
    {
        (var result, person) = _map.ContainsKey(name) switch
        {
            true => (true, _map[name]),
            false => (false, default)
        };

        return result;
    }
}


//!1!
// If you just create CharacterRepository without using Add you will not have object, thus the objext is null