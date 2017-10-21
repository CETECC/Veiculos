using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Classes
{
    public abstract class Veiculo
    {
        public int QtdPessoas { get; set; }
        public float VelocidadeMaxima { get; set; }
        public string Propulsao { get; set; }
    }
}
