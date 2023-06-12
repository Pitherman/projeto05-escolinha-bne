using System;

class Futuro
{
    public double VF = 7390.61;
    public double taxa;
    public int periodo;


    public double valorP()
    {
        return (VF/Math.Pow((1+taxa/100), periodo));
    }



    public void tabela()
    { 
        double vInicial = Math.Round(valorP(), 2);
        Console.WriteLine("\n| Valor aplicado: R$"+vInicial+" | Valor atual: R$"+VF+" | Taxa: "+taxa+"% | Período: "+periodo+" anos |\n");
    }
}
