/*int[] myNumbers = new int[5] {12,34,66,-45,23};

//Console.WriteLine(myNumbers[4]); //앞에서부터 0임. 0하면 12불러와짐

//Console.WriteLine(myNumbers[^1]); //뒤에서부터 1임. 23 불러와짐

//Console.WriteLine(myNumbers[1..^2]); //안된이유?

//myNumbers[1] = 87;//데이터 체인지
//Console.WriteLine(myNumbers[1]);

Console.WriteLine(myNumbers.Length); //array 갯수?
*/

/*
string firstName = "Joel";
List<string> names = new List<string>();
string[] names2 = new string[5];

names.Add(firstName);
names.Add("Larry");
names.Add("Mary");

//names.Remove(firstName);
//names.RemoveAt(3);
//names.Clear();
bool isNameFound = names.Contains("Joel"); //있냐없냐

//Array vs Lists 차이 설명

foreach (string name in names)
{
    Console.WriteLine(name);
}
*/

string[] names = new string[2] {"Larry","Joel"};

for (int i = 0; i < names.Length; i++) //얼마나 많은 루프를 돌거냐
{
    Console.WriteLine(names[i]);
}