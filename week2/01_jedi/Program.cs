
using System.Diagnostics.CodeAnalysis;

var a=new Jedi(name: "Ankin Skywalker", isMaster: false);
var b=new Jedi(name: "Darth Vidar", isMaster: true);
var c = new Jedi(name: "Ankin Skywalker", isMaster: false);

var cmp =object.Equals(a, b);
Console.WriteLine(cmp);

var cmp1 = object.Equals(a, c);
Console.WriteLine(cmp1);

// Class named Jedi
// Properties: Name, IsMaster
class Jedi
{
    public required string Name { get; init; }
    public required bool IsMaster { get; init; }

    // constructor
    [SetsRequiredMembers] // TODO remind what is the [] ?
    public Jedi(string name, bool isMaster)
    {
        Name = name;
        IsMaster = isMaster;
    }

    // value equality
    public override bool Equals(object? obj) // TODO: What is ?
    {
        if (obj is Jedi other)
        {
            return IsMaster == other.IsMaster && string.Equals(Name, other.Name,StringComparison.InvariantCultureIgnoreCase);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name.ToLower(), IsMaster);
    }   
}

