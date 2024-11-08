using System;
public class Programa
{
    public static void Main(string[] arg)
    {
        int Soma = 0;
        for(int a=0; a<=50; a ++ )
        {
            if(a % 2 != 0)
            {
                Soma = Soma + a;
                
            }

        }

        Console.WriteLine("Total Numeros impares=" + Soma);
    }
    
}
