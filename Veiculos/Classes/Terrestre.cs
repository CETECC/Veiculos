using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos.Classes
{
    public abstract class Terrestre : Veiculo
    {
        public int QtdRodas { get; set; }
        public bool PossuiEsteira { get; set; }
        public string TipoMotor { get; set; }
    }
}
