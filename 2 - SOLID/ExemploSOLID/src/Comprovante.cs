namespace ExemploSOLID.src
{
    public class Comprovante
    {
        public string usuarioLogado { get; set; }
        public string descricao  { get; set; }
        public double valor  { get; set; }
        public TipoPagamento tipoPagamento { get; set; }

        public Comprovante(string descricao, double valor, TipoPagamento tipoPagamento)
        {
            this.usuarioLogado = UsuarioLogadoService.GetUsuarioLogado();
            this.descricao = descricao;
            this.valor = valor;
            this.tipoPagamento = tipoPagamento;
        }
    }
}