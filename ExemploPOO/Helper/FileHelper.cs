namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho)
        {
           var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
         }

         public void ListarAquivosDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetFiles(caminho, "*2*", SearchOption.AllDirectories);
            foreach (var retorno in retornoCaminho)
            {
                Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorios(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);


        }

        public void ApagarDiretorios(string caminho, bool apagarAquivos)
        {
            Directory.Delete(caminho, apagarAquivos);
        }

        public void CriarArquivosTexto(string caminho, string conteudo)
        {   
           if(!File.Exists(caminho))
           {
               File.WriteAllText(caminho, conteudo); 
           }
           else
           {
               System.Console.WriteLine("Arquivo já existe");
           }
           
        }

        public void CriarArquivosTextoStream(string caminho, List<string> conteudo)
        {
            using (var stream = File.CreateText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }           
        } 

        public void AdcionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdcionarTextoSream(string caminho, List<string> conteudo)
        {
            using (var stream = File.AppendText(caminho))
            {
                foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }
            }
        }

        public void LerArquivoTexto(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoTextoStream(string caminho)
        {   
            string linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
           
        }

        public void MoverArquivo(string caminhoOrigem, string caminhoDestino, bool sobreescrever)
        {
            File.Move(caminhoOrigem, caminhoDestino, sobreescrever);
        }
        
        public void CopiarArquivo(string caminhoOrigem, string caminhoDestino, bool sobreescrever)
        {
            File.Copy(caminhoOrigem, caminhoDestino, sobreescrever);
        }
        
        public void ApagarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}