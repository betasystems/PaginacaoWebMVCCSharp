namespace PaginacaoWebMVCCSharp.Negocio
{
    public class PesquisaTeste
    {
        public Models.PesquisaTeste RecuperarTodosPaginado(int paginaAtual)
        {
            try
            {
                var registrosTotal = 0;

                if (paginaAtual == 0)
                {
                    paginaAtual = 1;
                }

                var listaPesquisaTeste = new Repositorio.PesquisaTeste().RecuperarTodosPaginado(paginaAtual, 10, out registrosTotal);

                var PesquisaTeste = new Models.PesquisaTeste();
                PesquisaTeste.RegistrosTotal = registrosTotal;
                PesquisaTeste.ListaPesquisaTeste = listaPesquisaTeste;

                return PesquisaTeste;
            }
            catch
            {
                throw;
            }
        }
    }
}