﻿using System;
using System.IO;
using System.Threading;

namespace progmclau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando o rendimensionador");

            Thread thread = new System.Threading.Thread(Redimensionar);
            thread.Start();

            Console.Read();
        }

        private static void Redimensionar()
        {
            #region "Diretorios"
            string diretorio_entrada = "Arquivos_entrada";
            if (!Directory.Exists(diretorio_entrada))
            {
                Directory.CreateDirectory(diretorio_entrada);
            }
            string diretorio_redimensionado = "Arquivos_redimensionado";
            if (!Directory.Exists(diretorio_redimensionado))
            {
                Directory.CreateDirectory(diretorio_redimensionado);
            }

            string diretorio_finalizado = "Arquivos_Finalizado";
            if (!Directory.Exists(diretorio_finalizado))
            {
                Directory.CreateDirectory(diretorio_finalizado);
            }
            #endregion

            while (true)
            {
                //Meu programa vai olhar para a pasta de entrada
                // se tiver arquivo, ele irá redimensionar

                var arquivosEntrada = Directory.EnumerateFiles(diretorio_entrada);


                // Ler o tamanho que irá redimensionar


                foreach (string arquivo in arquivosEntrada)
                {

                    FileStream file = new FileStream(arquivo, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
                    FileInfo fileInfo = new FileInfo(arquivo);
                    Console.WriteLine(arquivo);
                }



                // Ler o tamanho que irá redimensionar




                //redimensiona
                //copia os arquivos redimensionados para a pasta de redimensionados
                //move o arquivo de entrada para a pasta de finalizados
            }

            }
        }
    }
