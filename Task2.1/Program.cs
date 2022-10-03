Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
if (n>0)
    if (n<=5)
    {
    Console.Write("Рабочий день");
    }
else if (n==6)

{
   Console.Write("Выходной"); 
}

else if (n==7)

{
   Console.Write("Выходной день"); 
}

else Console.Write("Это не день недели");