using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入身高:");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("請輸入體重:");
            double B = Convert.ToDouble(Console.ReadLine());

            double BMI = B / (A * A / 10000);
            if (BMI >= 27)
            {
                Console.WriteLine("肥胖");
            }
            if (BMI >= 24 && BMI < 27)
            {
                Console.WriteLine("過重");
            }
            if (BMI >= 18.5 && BMI < 24)
            {
                Console.WriteLine("適中");

            }
            if (BMI < 18.5)
            {
                Console.WriteLine("過瘦");
            }

            Console.WriteLine("BMI=" + BMI);

            Console.ReadLine();
        }
    }
}
