using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploSOLID.src
{
    public class ComprovanteCredito : Comprovante
    {
        public int? numParcelas { get; set; }

        public ComprovanteCredito(int? numParcelas, string descricao, double valor, TipoPagamento tipoPagamento) : base(descricao, valor, tipoPagamento)
        {
            this.numParcelas = numParcelas;
            this.descricao = descricao;
            this.valor = valor;
            this.tipoPagamento = tipoPagamento;
        }
    }
}