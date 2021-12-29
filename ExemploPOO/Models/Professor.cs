namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        public sealed override void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome} eu sou um profesasor e ganho {Salario}.");
         }
    }
}