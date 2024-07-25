//     Example 1 
int x = 0;
while (x < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    x++;
}
Console.WriteLine("---------------------------------------");
//     Example 2 : 1 ve 20 arasındaki sayılar 
int i  = 2;
while (i < 20)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("--------------------------------------");
//    Example 3 : 1 ve 20 arasındaki çift sayılar
int y = 2;
while (y < 20)
{
    if (y % 2 == 0)
    { Console.WriteLine(y);
    
    }
    y++;
}
Console.WriteLine("--------------------------------------");
//    Example 4 : 50 ile 150 arasındaki sayılarım toplamı
int u = 51;
int sayı = 0;
while (u < 149)
{
    sayı = u + sayı;
    u++;
}
Console.WriteLine("Sayıların Toplamı ->" + sayı );
Console.WriteLine("--------------------------------------");
//    Example 5 : 1 ile 120 arasındaki tek ve çift sayıların toplamı
int tekSayıTop = 0;
int ciftSayıTop  = 0;
int q = 2;  
while(q < 119)
{
    if (q % 2 == 0)
    {
        ciftSayıTop += q;
    }
    else
    {
        tekSayıTop += q;
    }
   q++;
}
Console.WriteLine("Tek Sayıların Toplamı ->" + tekSayıTop);
Console.WriteLine("Çift Sayıların Toplamı ->" + ciftSayıTop);
