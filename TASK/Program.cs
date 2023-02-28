string[] MassivIn;
Console.WriteLine("Введите массив строк через пробел:");
string stroka = Console.ReadLine();
MassivIn = stroka.Split(' ');
string[] MassivOut = new string[MassivIn.Length];

int indexOut = 0;
for (int index = 0; index < MassivIn.Length; index++)
{
    if (MassivIn[index].Length <= 3)
    {
        MassivOut[indexOut] = MassivIn[index];
        indexOut++;
    }
}

for (int i = 0; i < MassivOut.Length; i++)
{
    Console.WriteLine(MassivOut[i]);
}

