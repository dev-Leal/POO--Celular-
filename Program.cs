﻿using System;

namespace SS_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            celular iphone = new celular ();
            iphone.modelo = "Iphone 8 Plus";
            iphone.tamanho = 10f;
            iphone.ligado = false;

            
            if (iphone.ligado){
                Console.WriteLine(iphone.Ligando());
                Console.WriteLine(iphone.EnviarMsg());
            }
            else{
                Console.WriteLine("O celular esta desligado");
                
            }
        }
    }
}
