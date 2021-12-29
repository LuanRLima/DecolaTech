namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else{
                throw new Exception("Comprimento e largura devem ser maiores que zero.");
            }
        }

        public double CalcularArea()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                throw new Exception("Preencha valores validos");
            }
        }
    }
}