int a;
string result;

Console.WriteLine("Введите число ");
a = int.Parse(Console.ReadLine());  

if(a%2==0)
{
    result="четное";
}
else
{
    result="нечетное";
}
    

Console.Write("result= "); 
Console.Write(result); 
