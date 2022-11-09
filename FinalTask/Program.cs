// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите елементы строки через побел");
string strigElemens = Console.ReadLine();
string[] inputUserStrigArr = strigElemens.Split(new Char[] {' '});

for (int i = 0; i < inputUserStrigArr.Length; i++)
{
    Console.WriteLine(inputUserStrigArr[i]);
}

string[] resultArrayFull(string[] inputStrigArr)
{
    int arrayLeng = 0;
    string[] resultArray = new string[arrayLeng];
    for (int i = 0; i < inputStrigArr.Length; i++)
    {
        if (inputStrigArr[i].Length < 3)
        {
            arrayLeng++;
            resultArray[i] = inputStrigArr[i];
            Console.WriteLine(resultArray[i]);
        }
    }
    return resultArray;
}
resultArrayFull(inputUserStrigArr);
string[] resultArray = resultArrayFull(inputUserStrigArr);

