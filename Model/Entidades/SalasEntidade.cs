using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    public class SalasEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Numerocomputadores { get; set; }
        public int Islab { get; set; }
        public int NumeroCadeiras { get; set; }
        public bool Disponivel { get; set; }

    }
}
