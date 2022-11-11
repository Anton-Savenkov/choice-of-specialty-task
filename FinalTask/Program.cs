
Console.WriteLine("Введите елементы строки через побел");
string strigElemens = Console.ReadLine();
string[] inputUserStrigArr = strigElemens.Split(new Char[] {' '});
Console.WriteLine("Начальный массив: [" + string.Join(", ", inputUserStrigArr) + "]");

void printElemrntsArray(string[] inputArray)
{
    List<string> resultArray = new List<string>();
    for (int i = 0; i < inputArray.Length; i++)
    {
       if(inputArray[i].Length < 3)
       {
            string temp = inputArray[i];
            resultArray.Add(temp);
       }
    }
    
    Console.WriteLine("Итоговый массив: [" + string.Join(", ", resultArray) + "]");
}
printElemrntsArray(inputUserStrigArr);