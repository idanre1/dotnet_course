namespace EliminateWarnings;

public class Dwarve : Person
{
//    public string Title { get; init; }
    public string? Title { get; init; }

    // missing: override gethash and equal
    //          for some reason it compiler don't complains
    public override bool Equals(object? obj)
    {
        //        var other = obj as Person;
        if (obj is Dwarve other) // Already check nullability
        {
            return base.Equals(obj) && string.Equals(Title, other.Title);
        }
        return false;
    }

    public override int GetHashCode()
    {
        // Why not use base.GetHashCode() and Color?
        // Bacause then you get a hash of int, combined with a string. and not a hash of 4 strings.
        return HashCode.Combine(FirstName, MiddleName, LastName, Title);
    }
}