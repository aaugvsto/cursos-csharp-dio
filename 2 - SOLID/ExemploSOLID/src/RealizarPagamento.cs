namespace ExemploSOLID.src
{
    public class RealizarPagamento
    {
        private EmissorComprovante _emissorComprovante;

        public RealizarPagamento(EmissorComprovante emissorComprovante)
        {
            this._emissorComprovante = emissorComprovante;
        }

        public Comprovante RegistrarPagamento(PagamentoRequest pagamentoRequest)
        {
            Comprovante comprovante = _emissorComprovante.emitir(pagamentoRequest);

            return comprovante;
        }
    }
}