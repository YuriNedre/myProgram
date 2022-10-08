# myProgram
string firstFriend = "Yuri";
string secondFriend = "IURII";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");
string greeting = "      Hello Turkey!       ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]");

string songLyrics = "With the lights out, it’s less dangerous Here we are now, entertain us I feel stupid and contagious Here we are now, entertain us";
Console.WriteLine(songLyrics.Contains("dangerous"));
Console.WriteLine(songLyrics.Contains("good"));
