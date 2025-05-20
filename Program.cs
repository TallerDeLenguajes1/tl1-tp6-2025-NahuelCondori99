// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);

string input = Console.ReadLine();
int num = int.Parse(input);
int invertido=0;
Console.WriteLine("Valor del numero:"+num);
while (num>0)
{
    invertido = invertido*10 + num%10;
    num = num/10;
}
Console.WriteLine("Valor invertido:"+invertido);
