using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Epifanov
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во самолётов");
            int count = Convert.ToInt32(Console.ReadLine());
 
            PlaneControl plane = new PlaneControl(count);
            plane.Fill();
            plane.Sort();
 
            Console.Read();     

        }
    }
}
                

      
