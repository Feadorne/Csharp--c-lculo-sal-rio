using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
      public static string setNome()
        {
            Console.WriteLine("Por favor insira o nome do usuário:");
            return Console.ReadLine();  
        }

        public static double setSalario()
        {
            Console.WriteLine("Por favor insira o salário do usuário:");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double setPercentual()
        {
            Console.WriteLine("Por favor insira o percentual de reajuste:");
            return Convert.ToDouble(Console.ReadLine());
        }

        public static double setSalarioBase(double salarioUsuario, double percentualReajuste)
        {
           return salarioUsuario + (salarioUsuario * (percentualReajuste / 100));
        }


        public static double setSalarioFinal(double salarioBase)
        {
            double salarioFinal = 0;

            const double FUNDO_GARANTIA = 7.5;
        }


        static void Main(string[] rgs)
        {
            string nomeUsuario;
            double salarioUsuario;
            double salarioFinal;
            double percentualReajuste;
            double salarioBase;



            nomeUsuario        = setNome();
            salarioUsuario     = setSalario();
            percentualReajuste = setPercentual();
            salarioBase         = setsalarioBase(salarioUsuario, percentualReajuste);
           
            Console.WriteLine(salarioFinal);
            

            Console.ReadLine();
        }

    }
}
