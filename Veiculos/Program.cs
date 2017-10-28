using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Veiculos.Classes;
using Veiculos.Interfaces;

namespace Veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Fusion carro = new Fusion();

            carro.Acelerador = "Acelerador da hora";
            carro.AlavancaCambio = "Cambio manual com caranguejo em cima";
            carro.Automatico = false;
            carro.Embreagem = "Embreagem manual Full Power Blaster";
            carro.Freio = "Freio tipo âncora (eu quero é ver o oco)";
            carro.QtdMarchas = 4;
            carro.Volante = "Volante Esportivo Vermelho";

            // EU, como motorista, sei dirigir a interface ICarro.
            Dirigir(carro);

            // Agora, eu vou dirigir outro carro
            Fusca carro2 = new Fusca();

            carro2.Acelerador = "Acelerador da hora";
            carro2.AlavancaCambio = "Cambio manual com caranguejo em cima";
            carro2.Automatico = false;
            carro2.Embreagem = "Embreagem manual Full Power Blaster";
            carro2.Freio = "Freio tipo âncora (eu quero é ver o oco)";
            carro2.QtdMarchas = 4;
            carro2.Volante = "Volante Esportivo Vermelho";

            // EU, como motorista, sei dirigir a interface ICarro.
            Dirigir(carro2);
        }

        static void Dirigir(ICarro carro)
        {
            carro.Ligar();
            Thread.Sleep(1500);
            carro.AndarParaFrente();
            Thread.Sleep(1500);
            carro.Acelerar(60.0f);
            Thread.Sleep(1500);
            carro.Desacelerar(30.0f);
            Thread.Sleep(1500);
            carro.Parar();
            Thread.Sleep(1500);
            carro.AndarParaTras();
            Thread.Sleep(1500);
            carro.Parar();
            Thread.Sleep(1500);
            carro.Desligar();
        }
    }
}
