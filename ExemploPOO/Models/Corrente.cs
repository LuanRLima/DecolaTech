namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void credditar(double valor)
        {
            base.saldo += valor;
        }
    }
}