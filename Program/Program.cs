// Задание 1

double num = Convert.ToDouble(Console.ReadLine());
if ( num <= 100 )
    Console.WriteLine(  num + num / 100 * 5 );
if ( num > 100 && num <= 200 )
    Console.WriteLine(  num + num / 100 * 7 );
if ( num > 200 )
    Console.WriteLine(  num + num / 10 );

// Задание 2
int[,,] mas = { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } }, 
                { { 10, 11 }, { 12, 13 } }
              };
Console.Write("{");
for (int i = 0; i < mas.GetLength(0); i++)
{
    Console.Write("{");
    for (int j = 0; j < mas.GetLength(1); j++)
    {
        Console.Write("{");
        for (int k = 0; k < mas.GetLength(2); k++)
        {
            if (k != mas.GetLength(2)-1)Console.Write(mas[i,j,k] +",");
            else
            {
                Console.Write(mas[i,j,k] +"");
            }
        }
        if (j != mas.GetLength(1)-1)Console.Write("},");
        else Console.Write("}");
    }
    if (i != mas.GetLength(0)-1)Console.Write("},");
    else Console.Write("}");
}
Console.WriteLine("}");

// Задание 3
int [] array = [6, 7, 2, 3, 9, 4, 7, 1, 3, 6, 8, 3, 7, 8, 3];
int sumMin = array[0] + array[1];
for (int i = 2; i < array.Length; i++)
{
    if ((array[i] + array[i-1]) <= sumMin )
    sumMin = array[i] + array[i-1];
}
Console.WriteLine($"resultTask3 = {sumMin}");

// Задание 8

string str = Console.ReadLine();
int countToZero = 0;
int countSymbol = 0;
for (int i = 0; i < str.Length; i++ )
{
    if ( str[i] == '+' || str[i] == '-' )
        countSymbol++;        
}
int index =0;
while ( str[index] != '0' )
{
    if (str[index] == '+' || str[index] == '-' ) countToZero++;
    index++;
    
}
Console.WriteLine($"\"{countSymbol}\" \"{countToZero}\"");
 


