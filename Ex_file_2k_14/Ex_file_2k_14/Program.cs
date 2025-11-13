using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Ex_file_2k_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string localFile = @"C:\Users\ColégioCruzeirodoSul.AzureAD\Documents\t1.txt";
            string destineFile = @"C:\Users\ColégioCruzeirodoSul.AzureAD\Documents\t2.txt";
            try
            {
                FileInfo fi = new FileInfo(localFile);
                fi.CopyTo(destineFile);
                string[] lihasDeArquivo = File.ReadAllLines(localFile);
                foreach (string linha in lihasDeArquivo)
                {
                    Console.WriteLine(linha);
                }
            }
            catch(IOException error)
            {
                Console.WriteLine("Houve um erro" + error.Message);
            }
        }
    }
}
