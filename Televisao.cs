using Laboratorio7;
using System;

public class Televisao : IEstadoBinario
{
    private int voltagem;
    private int potencia;
    private bool ligado;

    public Televisao(int v, int p)
    {
        voltagem = v;
        potencia = p;
        ligado = false;
    }

    public void Ligar(){
            ligado = true;
            while (voltagem != 220){
                System.Console.WriteLine("A voltagem deve ser igual a 220\n");
                System.Console.WriteLine("Se você não possue uma voltagem de 220, digite 0 para desligar");
                voltagem = Convert.ToInt32(Console.ReadLine());
                if (voltagem == 0){
                    ligado = false;
                    break;
                }
            }
    }
    public void Desligar(){
        ligado = false;
    }

    public EstadoBinario Estado 
    {
        get
        {
            if (ligado) 
                return EstadoBinario.Ligado;
            else
                return EstadoBinario.Desligado; 
            } 
        } 
}