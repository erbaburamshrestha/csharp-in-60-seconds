#nullable enable
string? name = null;

Console.WriteLine(name?.Length);        // prints an empty line
Console.WriteLine(name?.Length ?? 0);   // 0
Console.WriteLine(name ?? "Guest");     // Guest

name ??= "Baburam";
Console.WriteLine(name);                // Baburam
