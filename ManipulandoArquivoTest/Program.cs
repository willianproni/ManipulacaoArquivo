using System;
using System.IO;

namespace ManipulandoArquivoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Test\\Test.txt");
                /* sw.WriteLine("Treinamento de C#");
                 sw.WriteLine("Escrita de Arquivos com StreamWriter");*/
                sw.WriteLine("maria;araraquara;192;contato");
                sw.WriteLine("maria;araraquara;191;recado");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
            finally
            {
                Console.WriteLine("Execuntando o Bloco de Comandos.");
            }

            string line;
            try
            {
                StreamReader sr = new StreamReader("C:\\Test\\test.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.WriteLine("Fim da Leitura do Arquivo");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Arquivo Criado com Sucesso");
            }
        }
    }
}
