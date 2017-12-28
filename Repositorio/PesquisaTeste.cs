using System.Collections.Generic;
using System.Linq;

namespace PaginacaoWebMVCCSharp.Repositorio
{
    public class PesquisaTeste
    {
        public List<Models.ListaPesquisaTeste> RecuperarTodosPaginado(int paginaAtual, int registrosPagina, out int registrosTotal)
        {
            var listaPesquisaTeste = new List<Models.ListaPesquisaTeste>();

            for (int i = 0; i < 30; i++)
            {
                listaPesquisaTeste.Add(new Models.ListaPesquisaTeste()
                {
                    Id = i,
                    Propriedade1 = "Propriedade" + i.ToString(),
                    Propriedade2 = "Propriedade" + i.ToString(),
                    Propriedade3 = "Propriedade" + i.ToString()
                });
            }

            registrosTotal = listaPesquisaTeste.Count;

            return listaPesquisaTeste.Skip((paginaAtual - 1) * registrosPagina).Take(registrosPagina).ToList();
        }
    }
}