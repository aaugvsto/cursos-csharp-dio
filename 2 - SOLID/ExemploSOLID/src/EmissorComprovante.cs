namespace ExemploSOLID.src
{
    public class EmissorComprovante
    {
        Comprovante? comprovante;

        public Comprovante emitir(PagamentoRequest pagamentoRequest)
        {
            if(pagamentoRequest.tipoPagamento.Equals(TipoPagamento.CREDITO))
            {
                comprovante =
                    new ComprovanteCredito(pagamentoRequest.numParcelas, "Pagamento Realizado", pagamentoRequest.valor, pagamentoRequest.tipoPagamento);
            }
            else 
            {
                comprovante = 
                    new Comprovante("Pagamento Realizado", pagamentoRequest.valor, pagamentoRequest.tipoPagamento);
            }

            Database.save(comprovante);

            return comprovante;
        }
    }
}