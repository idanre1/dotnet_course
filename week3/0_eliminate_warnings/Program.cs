
using Dumpify;
using EliminateWarnings;

Person[] hobbits =
[
    new Person() { FirstName = "Bilbo", LastName = "Baggings" }, // Person() is a constructor notion
    new Person { FirstName = "Bungo", LastName = "Baggings" },   // Person is without construction notion which is also OK
    new Person { FirstName = "Gelladonna", LastName = "Took" },
];

var wizards = new[]
{
    new Wizard() { FirstName = "Gandalf", Color = "Grey" },
    new Wizard() { FirstName = "Gandalf", Color = "White" },
    new Wizard() { FirstName = "Radagast", Color = "Brown" },
    null,
};

var dwarves = new Dwarve[]
{
    new (){ FirstName = "Thrain", Title = "The Old" },
    new (){ FirstName = "Thror", Title = "King under the Mountain" },
    new (){ FirstName = "Thorin", LastName = "Oakenshield" },
};

var repo = new CharacterRepository();

var characters = hobbits.Concat(wizards).Concat(dwarves);
foreach (var character in characters)
{
    //    repo.Add(character);
    if (character is not null)
    {
        repo.Add(character);
    }
}

//if (repo.TryGetPerson(wizards[0].ToString(), out var wizard))
if (repo.TryGetPerson(wizards[0]!.ToString(), out var wizard)) // In production code you should not use !. It is just for demo
{
        wizard.ToString().Dump();
}

