using NullDemo;

// the ? makes a value nullable
int? i = null;

//default value for string is null
// reference types are already nullable
string s = null;

PersonModel p = null;
// p is a reference type

int j = 5;
int k = j;
j = 10;
// value of k would be 5

PersonModel test1 = new();
test1.Name = "Tim";
PersonModel test2 = test1;
test1.Name = "Sue";

Console.WriteLine(test1.Name);
Console.WriteLine(test2.Name);
// test2 and test1 will be "Sue"
// test2 is pointing to a reference not a value
