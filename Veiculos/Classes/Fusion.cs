using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veiculos.Interfaces;

namespace Veiculos.Classes
{
    public class Fusion : Terrestre, ICarro
    {
        public string Volante { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int QtdMarchas { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Acelerador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Freio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Embreagem { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AlavancaCambio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Automatico { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Acelerar(float velocidade)
        {
            throw new NotImplementedException();
        }

        public void AndarParaFrente()
        {
            throw new NotImplementedException();
        }

        public void AndarParaTras()
        {
            throw new NotImplementedException();
        }

        public void Desacelerar(float velocidade)
        {
            throw new NotImplementedException();
        }

        public void Desligar()
        {
            throw new NotImplementedException();
        }

        public bool Ligar()
        {
            throw new NotImplementedException();
        }

        public void Parar()
        {
            throw new NotImplementedException();
        }
    }
}
