using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperConversor
{
    internal class Conversor
    {
        internal static string BinarioParaHexa(string binario)
        {
            // Verifica se a string binária tem comprimento múltiplo de 4
            int resto = binario.Length % 4;
            if (resto != 0)
            {
                // Completa a string binária com zeros à esquerda
                binario = new string('0', 4 - resto) + binario;
            }

            // Converte de 4 bits em 4 bits para hexadecimal
            string hexa = string.Empty;
            for (int i = 0; i < binario.Length; i += 4)
            {
                string bloco = binario.Substring(i, 4);
                int valorDecimal = Convert.ToInt32(bloco, 2);
                hexa += valorDecimal.ToString("X");
            }

            return hexa;
        }

        internal static string HexaParaBinario(string hexadecimal)
        {
            string binario = string.Empty;
            foreach (char c in hexadecimal)
            {
                int valorDecimal = Convert.ToInt32(c.ToString(), 16); // Converte para decimal
                string binarioBloco = Convert.ToString(valorDecimal, 2).PadLeft(4, '0'); // Converte para binário com 4 bits
                binario += binarioBloco;
            }
            return binario;
        }

        internal static string HexaParaDecimal(string hex)
        {
            string dec = string.Empty;
            foreach (char c in hex)
            {
                int valorDecimal = Convert.ToInt32(c.ToString(), 16); // Converte para decimal
                dec = valorDecimal.ToString();
            }
            return dec;

        }

        internal static string DecimalParaHexa(string dec)
        {
            int integer = Convert.ToInt32(dec);
            return integer.ToString("X");
        }
        internal static string BinarioParaOctal(string binario)
        {
            // Converter o binário para decimal
            int decimalValue = Convert.ToInt32(binario, 2);

            // Converter o decimal para octal
            return Convert.ToString(decimalValue, 8);
        }

        // Função para converter octal para binário
        internal static string OctalParaBinario(string octal)
        {
            // Converter o octal para decimal
            int decimalValue = Convert.ToInt32(octal, 8);

            // Converter o decimal para binário
            return Convert.ToString(decimalValue, 2);
        }

        internal static string OctalParaHexadecimal(string octal)
        {
            // Converte o octal para um número inteiro
            int numeroDecimal = Convert.ToInt32(octal, 8);

            // Converte o número decimal para hexadecimal
            string hexadecimal = Convert.ToString(numeroDecimal, 16).ToUpper();

            return hexadecimal;
        }

        // Função que converte hexadecimal para octal
        internal static string HexadecimalParaOctal(string hexadecimal)
        {
            // Converte o hexadecimal para um número inteiro
            int numeroDecimal = Convert.ToInt32(hexadecimal, 16);

            // Converte o número decimal para octal
            string octal = Convert.ToString(numeroDecimal, 8);

            return octal;
        }

        public static int OctalParaDecimal(string octal)
        {
            int decimalValor = 0;
            int baseOcat = 1; // A base 8 para o sistema octal

            // Começamos da direita para a esquerda
            for (int i = octal.Length - 1; i >= 0; i--)
            {
                // Verifica se o caractere é um número válido (de 0 a 7)
                if (octal[i] < '0' || octal[i] > '7')
                {
                    throw new FormatException("O número octal contém caracteres inválidos.");
                }

                // Converte o caractere para inteiro e multiplica pela base de 8 elevada à posição
                decimalValor += (octal[i] - '0') * baseOcat;
                baseOcat *= 8;
            }

            return decimalValor;
        }

        // Função para converter decimal para octal
        public static string DecimalParaOctal(int decimalValor)
        {
            if (decimalValor == 0)
            {
                return "0";
            }

            string octal = "";

            while (decimalValor > 0)
            {
                int resto = decimalValor % 8; // Resto da divisão por 8
                octal = resto.ToString() + octal; // Adiciona o resto na frente da string octal
                decimalValor /= 8; // Atualiza o valor decimal
            }

            return octal;
        }
    }
}
