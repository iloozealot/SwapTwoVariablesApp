

int? variableOne  = 5;
int? variableTwo = 2;
int? variableThree = null;

//Console.WriteLine($"variableTwo is {variableOne} and variableOne is {variableTwo}.");

variableThree = variableOne;
variableOne = variableTwo;
variableTwo = variableThree;

Console.WriteLine($"{variableOne}, {variableTwo}");

