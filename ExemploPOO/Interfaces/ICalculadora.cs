namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
         int Somar(int num, int num2);
         int Subtrair(int num, int num2);
        int Multiplicar(int num, int num2);
        int Dividir(int num, int num2)
        {
            return num / num2;
        }
    }
}