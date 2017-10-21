using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Interfaces
{
    public interface ICarro
    {
        string Volante { get; set; }
        int QtdMarchas { get; set; }
        string Acelerador { get; set; }
        string Freio { get; set; }
        string Embreagem { get; set; }
        string AlavancaCambio { get; set; }
        bool Automatico { get; set; }

        bool Ligar();
        void AndarParaFrente();
        void AndarParaTras();
        void Acelerar(float velocidade);
        void Desacelerar(float velocidade);
        void Parar();
        void Desligar();
    }
}
