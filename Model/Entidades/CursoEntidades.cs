using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entidades
{
    class CursoEntidades
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Turno { get; set; }
        public bool Ativo { get; set; }
    }
}
