using System.Collections.Generic;

namespace PaginacaoWebMVCCSharp.Models
{
    public class PesquisaTeste : InterfacePesquisaBase
    {
        public PesquisaTeste()
        {
            this.ListaPesquisaTeste = new List<Models.ListaPesquisaTeste>();
        }

        public List<ListaPesquisaTeste> ListaPesquisaTeste { get; set; }
    }
}