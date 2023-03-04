namespace ExemploSOLID.src
{
    public class PagamentoRequest
    {
        public double valor { get; set; }
        public TipoPagamento tipoPagamento { get; set; }
        public int? numParcelas { get; set; }
        public PagamentoRequest(TipoPagamento tipoPagamento, double valor, int? numParcelas = null)
        {
            this.valor = valor;
            this.tipoPagamento = tipoPagamento;
            this.numParcelas = numParcelas;
        }
    }
}