using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Veiculos.Interfaces;

namespace Veiculos.Classes
{
    public class Fusion : Terrestre, ICarro
    {
        public string Volante { get; set; }
        public int QtdMarchas { get; set; }
        public string Acelerador { get; set; }
        public string Freio { get; set; }
        public string Embreagem { get; set; }
        public string AlavancaCambio { get; set; }
        public bool Automatico { get; set; }

        public void Acelerar(float velocidade)
        {
            Console.WriteLine("Acelerando o Fusion a {0} Km/h", velocidade);
            Thread.Sleep(2000);
            Console.WriteLine("Fusion em {0} Km/h", velocidade);
        }

        public void AndarParaFrente()
        {
            Console.WriteLine("O Fusion está andando para frente");
        }

        public void AndarParaTras()
        {
            Console.WriteLine("O Fusion está andando para trás");
        }

        public void Desacelerar(float velocidade)
        {
            Console.WriteLine("Desacelerando o Fusion a {0} Km/h", velocidade);
            Thread.Sleep(2000);
            Console.WriteLine("Fusion em {0} Km/h", velocidade);
        }

        public void Desligar()
        {
            Console.WriteLine("Fusion desligado");
        }

        public bool Ligar()
        {
            Console.WriteLine("Ligando o Fusion");
            Thread.Sleep(1000);
            Console.WriteLine("Fusion ligado");

            return true;
        }

        public void Parar()
        {
            Console.WriteLine("Parando o Fusion");
            Thread.Sleep(2000);
            Console.WriteLine("Fusion parada");
        }
    }
}
