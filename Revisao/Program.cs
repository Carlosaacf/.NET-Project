using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            console.whiteLine("Informe a opção desejada:");
            console.whiteLine("1 - Inserir novo aluno");
            console.whiteLine("2 - Listar alunos");
            console.whiteLine("3 - Calcular media geral");
            console.whiteLine("X - Sair");
            console.whiteLine();

            string opcaoUsuario = console.ReadLine();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1";

                    break;
                    
                    case "2";

                    break;

                    case "3";

                    break;

                    default:
                    throw new ArgumentOutofRanger(Exception();
                }

                console.whiteLine("Informe a opção desejada:");
                console.whiteLine("1 - Inserir novo aluno");
                console.whiteLine("2 - Listar alunos");
                console.whiteLine("3 - Calcular media geral");
                console.whiteLine("X - Sair");
                console.whiteLine();

                opcaoUsuario = console.ReadLine();
            }

                       
                 
        }
    }
}
