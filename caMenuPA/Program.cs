using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CaProjetoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            do
            {
                // 1) Apresentando a lista de opções
                Clear();
                SetCursorPosition(30, 0);
                Write(" Menu Principal ");
                SetCursorPosition(0, 1);
                Write(new string('═', 80)); // char 205
                SetCursorPosition(30, 3); Write("[1] Conta letras");
                SetCursorPosition(30, 4); Write("[2] Zenit Polar");
                SetCursorPosition(30, 5); Write("[3] Fim");
                SetCursorPosition(0, 7);
                Write(new string('═', 80)); // char 205
                SetCursorPosition(30, 9);
                Write("Informe sua opção: ");

                // 2) Recebendo a escolha do usuário
                if (!int.TryParse(ReadLine(), out opc))
                {
                    opc = 0;
                }

                // 3) Decidindo o que fazer
                switch (opc)
                {
                    case 1:
                        ContaLetras();
                        break;
                    case 2:
                        ZenitPolar();
                        break;
                    case 3:
                        Clear();
                        WriteLine("Saindo...");
                        Thread.Sleep(100);
                        Clear();
                        WriteLine("Saindo..");
                        Thread.Sleep(100);
                        Clear();
                        WriteLine("Saindo.");
                        Thread.Sleep(100);
                        Clear();
                        WriteLine("Saindo..");
                        Thread.Sleep(100);
                        break;
                    default:
                        SetCursorPosition(30, 15);
                        Write("Opção inválida!");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opc != 6); // Sai do loop ao escolher a opção 6

        } // Fim do Main

        static void ContaLetras()
        {
            int vogaisA = 0, vogaisE = 0, vogaisI = 0, vogaisO = 0, vogaisU = 0;
            int consoantes = 0, caracteresEspeciais = 0, totalLetras = 0;
            string frase, letra;
            Clear();
            SetCursorPosition(30, 1);
            Write("Conta Letras");
            SetCursorPosition(1, 2);
            Write(new string('═', 80)); // char 205
            SetCursorPosition(28, 3);
            Write("Digite sua frase: ");
            frase = ReadLine();

            foreach (char c in frase)
            {
                letra = c.ToString().ToLower();

                switch (letra)
                {
                    case "a":
                        vogaisA++;
                        totalLetras++;
                        break;
                    case "e":
                        vogaisE++;
                        totalLetras++;
                        break;
                    case "i":
                        vogaisI++;
                        totalLetras++;
                        break;
                    case "o":
                        vogaisO++;
                        totalLetras++;
                        break;
                    case "u":
                        vogaisU++;
                        totalLetras++;
                        break;
                    default:
                        if (char.IsLetter(c))
                        {
                            consoantes++;
                            totalLetras++;
                        }
                        else
                        {
                            caracteresEspeciais++;
                        }
                        break;
                }
    }

        SetCursorPosition(1, 4);
        Write(new string('═', 80)); // char 205
        SetCursorPosition(30, 5); WriteLine($"Seu texto tem {vogaisA} vogais A"); //  "strings interpoladas permite inserir expressões diretamente dentro de uma string, facilitando a formatação e a construção de textos dinâmicos."
        SetCursorPosition(30, 6); WriteLine($"Seu texto tem {vogaisE} vogais E");
        SetCursorPosition(30, 7); WriteLine($"Seu texto tem {vogaisI} vogais I");
        SetCursorPosition(30, 8); WriteLine($"Seu texto tem {vogaisO} vogais O");
        SetCursorPosition(30, 9); WriteLine($"Seu texto tem {vogaisU} vogais U");
        SetCursorPosition(30, 10); WriteLine($"Consoantes: {consoantes}");
        SetCursorPosition(30, 11); WriteLine($"Total de letras: {totalLetras}");
        SetCursorPosition(30, 12); WriteLine($"Caracteres especiais: {caracteresEspeciais}");
        SetCursorPosition(1, 13);
        Write(new string('═', 80)); // char 205
        SetCursorPosition(30, 14); WriteLine("Pressione qualquer tecla para voltar ao menu.");
        ReadKey();
}



            static void ZenitPolar()
        {
            int opcao;
            do
            {
                Clear(); 
                SetCursorPosition(30, 2); WriteLine(" Zenit Polar ");
                SetCursorPosition(0, 4); Write(new string('═', 80)); // char 205
                SetCursorPosition(30, 6); WriteLine("[1] Criptografar uma frase");
                SetCursorPosition(30, 7); WriteLine("[2] Descriptografar uma frase");
                SetCursorPosition(30, 8); WriteLine("[3] Voltar ao menu principal");
                SetCursorPosition(30, 9); WriteLine(); Write(new string('═', 80)); // char 205
                SetCursorPosition(30, 11); Write("Escolha uma opção: ");

                if (!int.TryParse(ReadLine(), out opcao))
                {
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Write("Digite a frase a ser criptografada: ");
                        string fraseCriptografar = ReadLine();
                        string fraseCriptografada = ProcessarZenitPolar(fraseCriptografar, true);
                        WriteLine($"Frase criptografada: {fraseCriptografada}");
                        WriteLine("Pressione qualquer tecla para continuar...");
                        ReadKey();
                        break;
                    case 2:
                        Write("Digite a frase a ser descriptografada: ");
                        string fraseDescriptografar = ReadLine();
                        string fraseDescriptografada = ProcessarZenitPolar(fraseDescriptografar, false);
                        WriteLine($"Frase descriptografada: {fraseDescriptografada}");
                        WriteLine("Pressione qualquer tecla para continuar...");
                        ReadKey();
                        break;
                    case 3:
                        break;
                    default:
                        WriteLine("Opção inválida! Tente novamente.");
                        Thread.Sleep(2000);
                        break;
                }

            } while (opcao != 3);
        }

        static string ProcessarZenitPolar(string frase, bool criptografar)
        {
            string resultado = "";
            foreach (char c in frase)
            {
                char novoCaractere = c;

                if (criptografar)
                {
                    switch (char.ToLower(c))
                    {
                        case 'z': novoCaractere = 'p'; break;
                        case 'e': novoCaractere = 'o'; break;
                        case 'n': novoCaractere = 'l'; break;
                        case 'i': novoCaractere = 'a'; break;
                        case 't': novoCaractere = 'r'; break;
                        case 'p': novoCaractere = 'z'; break;
                        case 'o': novoCaractere = 'e'; break;
                        case 'l': novoCaractere = 'n'; break;
                        case 'a': novoCaractere = 'i'; break;
                        case 'r': novoCaractere = 't'; break;
                    }
                }
                else
                {
                    switch (char.ToLower(c))
                    {
                        case 'p': novoCaractere = 'z'; break;
                        case 'o': novoCaractere = 'e'; break;
                        case 'l': novoCaractere = 'n'; break;
                        case 'a': novoCaractere = 'i'; break;
                        case 'r': novoCaractere = 't'; break;
                        case 'z': novoCaractere = 'p'; break;
                        case 'e': novoCaractere = 'o'; break;
                        case 'n': novoCaractere = 'l'; break;
                        case 'i': novoCaractere = 'a'; break;
                        case 't': novoCaractere = 'r'; break;
                    }
                }

                resultado += novoCaractere;
            }
            return resultado;
        }

    }
}
// ctrl + k + ctrl + f = identar o códigos 