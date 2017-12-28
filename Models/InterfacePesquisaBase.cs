using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginacaoWebMVCCSharp.Models
{
    public class InterfacePesquisaBase
    {
        public InterfacePesquisaBase()
        {
            this.RegistrosPagina = 10;
        }

        public int NumeroPesquisa { get; set; }
        public string TermoPesquisa { get; set; }
        public int PaginaAtual { get; set; }
        public int RegistrosPagina { get; set; }
        public int RegistrosTotal { get; set; }
    }
}