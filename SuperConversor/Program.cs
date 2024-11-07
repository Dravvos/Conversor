using System.Text.RegularExpressions;

namespace SuperConversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var loop = true;
            Console.WriteLine("Bem vindo ao conversor ultra mega master blaster gigatonico\n\n");

            while (loop)
            {
                
                Console.WriteLine("===================================");
                Console.WriteLine("       MENU PRINCIPAL");
                Console.WriteLine("===================================");
                Console.WriteLine("1. Binário para decimal");
                Console.WriteLine("2. Decimal para binário");
                Console.WriteLine("3. Binário para hexadecimal");
                Console.WriteLine("4. Hexadecimal para binário");
                Console.WriteLine("5. Decimal para hexadecimal");
                Console.WriteLine("6. Hexadecimal para decimal");
                Console.WriteLine("7. Decimal para octal");
                Console.WriteLine("8. Hexadecimal para octal");
                Console.WriteLine("9. Binário para octal");
                Console.WriteLine("10. Octal para binário");
                Console.WriteLine("11. Octal para decimal");
                Console.WriteLine("12. Octal para hexadecimal");
                Console.WriteLine("===================================");
                Console.WriteLine("0. Sair");
                Console.WriteLine("===================================");
                int conversor = 0;
                while (int.TryParse(Console.ReadLine(), out conversor) == false)
                {
                    Console.WriteLine("Digite o número da opção");
                }
                if (conversor == 0)
                    Environment.Exit(-1);

                string? resposta = "";
                switch (conversor)
                {
                    //binário para decimal
                    case 1:
                        Console.Write("Digite um número binário para ser convertido em decimal: ");
                        resposta = Console.ReadLine();

                        if (IsBinary(resposta))
                        {
                            Console.WriteLine($"O número {resposta} em decimal fica {Convert.ToInt32(resposta, 2)}");
                        }
                        else
                            Console.WriteLine("Digite um número binário");
                        break;

                    //decimal para binário
                    case 2:
                        Console.Write("Digite um número decimal para ser convertido em binário: ");
                        resposta = Console.ReadLine();

                        if (int.TryParse(resposta, out int num))
                        {
                            Console.WriteLine($"O número {resposta} em binário fica {Convert.ToString(num, 2)}");
                        }
                        else
                            Console.WriteLine("Digite um número decimal");

                        break;

                    //binário para hexa
                    case 3:
                        Console.Write("Digite um número binário para ser convertido em hexadecimal: ");
                        resposta = Console.ReadLine();
                        if (IsBinary(resposta))
                        {
                            string res = Conversor.BinarioParaHexa(resposta);
                            Console.WriteLine($"O número {resposta} em hexadecimal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número binário");
                        break;

                    //hexa para binário
                    case 4:
                        Console.Write("Digite um número hexadecimal para ser convertido em binário: ");
                        resposta = Console.ReadLine();
                        if (IsHex(resposta))
                        {
                            string res = Conversor.HexaParaBinario(resposta);
                            Console.WriteLine($"O número {resposta} em binário fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número hexadecimal");

                        break;

                    //decimal para hexa
                    case 5:
                        Console.Write("Digite um número decimal para ser convertido em hexadecimal: ");
                        resposta = Console.ReadLine();
                        if (IsBinary(resposta))
                        {
                            string res = Conversor.DecimalParaHexa(resposta);
                            Console.WriteLine($"O número {resposta} em hexadecimal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número decimal");
                        break;

                    //hexa para decimal
                    case 6:
                        Console.Write("Digite um número hexadecimal para ser convertido em decimal: ");
                        resposta = Console.ReadLine();
                        if (IsHex(resposta))
                        {
                            string res = Conversor.HexaParaDecimal(resposta);
                            Console.WriteLine($"O número {resposta} em decimal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número hexadecimal");
                        break;

                    //decimal para octal
                    case 7:
                        Console.Write("Digite um número decimal para ser convertido em octal: ");
                        resposta = Console.ReadLine();
                        if (int.TryParse(resposta, out int number))
                        {
                            string res = Conversor.DecimalParaOctal(number);
                            Console.WriteLine($"O número {resposta} em octal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número decimal");
                        break;

                    //octal para decimal
                    case 8:
                        Console.Write("Digite um número octal para ser convertido em decimal: ");
                        resposta = Console.ReadLine();
                        if (IsOctal(resposta))
                        {
                            int res = Conversor.OctalParaDecimal(resposta);
                            Console.WriteLine($"O número {resposta} em decimal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número octal");
                        break;

                    //binário para octal
                    case 9:
                        Console.Write("Digite um número binário para ser convertido em octal: ");
                        resposta = Console.ReadLine();
                        if (IsBinary(resposta))
                        {
                            string res = Conversor.BinarioParaOctal(resposta);
                            Console.WriteLine($"O número {resposta} em octal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número binário");
                        break;

                    //octal para binário
                    case 10:
                        Console.Write("Digite um número octal para ser convertido em binário: ");
                        resposta = Console.ReadLine();
                        if (IsOctal(resposta))
                        {
                            string res = Conversor.OctalParaBinario(resposta);
                            Console.WriteLine($"O número {resposta} em binário fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número octal");
                        break;

                    //octal para decimal
                    case 11:
                        Console.Write("Digite um número octal para ser convertido em decimal: ");
                        resposta = Console.ReadLine();
                        if (IsOctal(resposta))
                        {
                            int res = Conversor.OctalParaDecimal(resposta);
                            Console.WriteLine($"O número {resposta} em decimal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número octal");
                        break;

                    //decimal para octal
                    case 12:
                        Console.Write("Digite um número decimal para ser convertido em octal: ");
                        resposta = Console.ReadLine();
                        if (int.TryParse(resposta, out int numero))
                        {
                            string res = Conversor.DecimalParaOctal(numero);
                            Console.WriteLine($"O número {resposta} em octal fica {res}");
                        }
                        else
                            Console.WriteLine("Digite um número decimal");
                        break;
                    default:
                        break;
                }
                string? conv = "";
                while (conv.ToUpper() != "S" || conv.ToUpper() != "N")
                {
                    Console.Write("Deseja fazer outra conversão (S/N):");
                    conv = Console.ReadLine();
                    if (conv.Equals("S", StringComparison.OrdinalIgnoreCase) || conv.Equals("N", StringComparison.OrdinalIgnoreCase))
                        break;
                }
                if (conv.Equals("N", StringComparison.OrdinalIgnoreCase))
                {
                    loop = false;
                    break;
                }


            }
            Console.WriteLine("Aperte qualquer tecla para sair");
            Console.ReadKey();
        }


        static bool IsBinary(string? input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }
        static bool IsHex(string input)
        {
            bool isHex;
            foreach (var c in input)
            {
                isHex = ((c >= '0' && c <= '9') ||
                         (c >= 'a' && c <= 'f') ||
                         (c >= 'A' && c <= 'F'));

                if (!isHex)
                    return false;
            }
            return true;
        }
        static bool IsOctal(string input)
        {
            return Regex.IsMatch(input, "^[0-7]+$");
        }
    }
}
