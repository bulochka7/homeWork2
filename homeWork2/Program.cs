// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

int SecondDigit(int num)
{
    int dec=num/ 10;
    int ed=dec% 10;
    return ed;
}
Console.WriteLine("Input number ");
int n =Convert.ToInt32(Console.ReadLine());
int secondDigit=SecondDigit(n);
if(n>=100)
    Console.WriteLine(secondDigit); 
else  
    Console.WriteLine("Wrong input"); 
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int ThirdDigit(int num)
{
    int ed;

    if (num<1000)
        ed=num%10;
    else
    {
        ed=(num%100)/10;
    }

    return ed;
}
Console.WriteLine("Input number ");
int n =Convert.ToInt32(Console.ReadLine());
int thirdDigit=ThirdDigit(n);
if(n>=100) 
    Console.WriteLine(thirdDigit); 
else 
    Console.WriteLine("There is no third digit ");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
/*
void FindDay(int num)
{
    if (num==6 || num==7)
        Console.WriteLine("Ура, этот день выходной");
    else   
    {
        Console.WriteLine("Опять работать");
    }
    
}
Console.WriteLine("Input number ");
int n =Convert.ToInt32(Console.ReadLine());
FindDay(n);
*/

