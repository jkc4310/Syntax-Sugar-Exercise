//--------explicite Typing-----------//
//int answer = 4;//
//string response;
//if (answer < 9)
//{
//response = answer + " is less than nine";
//}
//else
//    response = answer + " is greater than or equal to nine";
//
//--------interpolation Typing-----------//
var answer = 4;
var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

Console.WriteLine(response);

//--------inferred Typing-----------//

var answertwo = 4;
var responsetwo = string.Empty;

if (answertwo < 9)
{
    responsetwo = answertwo + "is less than 0";
}
else
{
    responsetwo = answertwo + "is equal to or greater than 9";
}

//--------Ternary Typing-----------//
//I think?//

int answerthree = 4;
string responsethree = answerthree < 9 ? answerthree + " is less than nine" : answerthree + "is greater than or equal to";
