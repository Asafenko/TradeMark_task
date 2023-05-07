using TradeMark;

string[] queries =
{
    "Booble",
    "yyyess",
    "oooops",
    "ooooooops",
    "Boooble",
    "yyessss",
    "yyessss",
    "oooops",
    "ooooppssss"
};

Register register = new Register();

foreach(var el in queries )
{
    register.Registration(el);
}


register.ListMarks();
Console.WriteLine(register.Count);