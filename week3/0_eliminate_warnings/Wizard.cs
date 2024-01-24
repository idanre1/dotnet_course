namespace EliminateWarnings;

public class Wizard : Person
{
//    public string Color { get; set; }
    public required string Color { get; set; }

    // missing: override gethash and equal
    //          for some reason it compiler don't complains
    public override bool Equals(object? obj)
    {
        //        var other = obj as Person;
        if (obj is Wizard other) // Already check nullability
        {
            return base.Equals(obj) && string.Equals(Color, other.Color);
        }
        return false;
    }

    public override int GetHashCode()
    {
        // Why not use base.GetHashCode() and Color?
        // Bacause then you get a hash of int, combined with a string. and not a hash of 4 strings.
        return HashCode.Combine(FirstName, MiddleName, LastName,Color);
    }
}