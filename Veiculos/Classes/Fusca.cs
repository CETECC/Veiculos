using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Veiculos.Interfaces;

namespace Veiculos.Classes
{
    public class Fusca : Terrestre, ICarro
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
            Console.WriteLine("Acelerando a Fuka Bala a {0} Km/h", velocidade);
            Thread.Sleep(2000);
            Console.WriteLine("Fuka Bala em {0} Km/h", velocidade);
        }

        public void AndarParaFrente()
        {
            Console.WriteLine("A Fuka Bala está andando para frente");
        }

        public void AndarParaTras()
        {
            Console.WriteLine("A Fuka Bala está andando para trás");
        }

        public void Desacelerar(float velocidade)
        {
            Console.WriteLine("Desacelerando a Fuka Bala a {0} Km/h", velocidade);
            Thread.Sleep(2000);
            Console.WriteLine("Fuka Bala em {0} Km/h", velocidade);
        }

        public void Desligar()
        {
            Console.WriteLine("Fuka Bala desligada");
        }

        public bool Ligar()
        {
            Console.WriteLine("Ligando a Fuka Bala");
            Thread.Sleep(1000);
            Console.WriteLine("Fuka Bala ligada");

            return true;
        }

        public void Parar()
        {
            Console.WriteLine("Parando a Fuka Bala");
            Thread.Sleep(2000);
            Console.WriteLine("Fuka Bala parada");
        }
    }
}
