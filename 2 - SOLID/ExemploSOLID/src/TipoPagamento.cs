using System.Runtime.Serialization;

namespace ExemploSOLID.src
{
    public enum TipoPagamento
    {
        [EnumMember(Value = "Debito")]
		DEBITO,
		[EnumMember(Value = "Credito")]
		CREDITO
    }
}