namespace ExemplosDiretorios
{
    public class Diretorio
    {
        public void ListarDiretorio(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                 System.Console.WriteLine(retorno);
            }
            
        }

        public void CriarDiretorio(string caminho)
        {
            var retorno = Directory.CreateDirectory(caminho);
            System.Console.WriteLine(retorno.FullName);
        }

        public void ApagarDiretorio(string caminho, bool apagarDiretorio)
        {
            Directory.Delete(caminho, apagarDiretorio);
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                } 
            }
            
        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho))
            {
                foreach(var linha in conteudo)
                {
                    stream.WriteLine(linha);
                } 
            }
            
        }

        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);

            foreach(var linha in conteudo)
            { 
                System.Console.WriteLine(linha);
            }
        }

        public void LerArquivoStream(string caminho)
        {
            var linha = string.Empty;

            using (var stream = File.OpenText(caminho))
            {
                while ((linha = stream.ReadLine()) != null)
                {
                     System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Move(caminho, novoCaminho, sobrescrever);
        }

        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever)
        {
            File.Copy(caminho, novoCaminho, sobrescrever);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

    }
}