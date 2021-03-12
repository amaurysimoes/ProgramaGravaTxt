using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExemploProgramaGravaTxt
{
    class arquivoTexto
    {
        private static string _file = @"C:\Temp\usuario.txt";
        private static void verifyFile()
        {
            if (!File.Exists(_file))
            {
                File.Create(_file);
            }
        }
        public static void writeData(String nome, String email, String descricao)
        {
            verifyFile();
            StreamWriter streamW = new StreamWriter(_file, true);
            streamW.WriteLine("Nome: " + nome + "| E-mail: " + email + "| Descrição: " + descricao);
            streamW.Close();
        }

        public static string readFile()
        {
            string text = "";
            verifyFile();
            StreamReader streamR = new StreamReader(_file);
            text = streamR.ReadLine();
            streamR.Close();
            return text;
        }

    }
}
