using ExemploSOLID.src;

namespace ExemploSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealizarPagamento realizarPagamento = new RealizarPagamento(new EmissorComprovante());
        }

        public static PagamentoRequest createPagamentoRequest()
        {
            return new PagamentoRequest(TipoPagamento.DEBITO, 200);
        }

        public static PagamentoRequest createPagamentoCreditoRequest()
        {
            return new PagamentoRequest(TipoPagamento.CREDITO, 200, 10);
        }
    }
}
