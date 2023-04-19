using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Epifanov
{
    public class PlaneControl
    {
        // Хранение массива, сортировки и вывода в файл. Работает с классом PrintToFile

        int PlaneC;
        public Plane[] Planes;


        public PlaneControl(int cPlanes)
        {
            this.PlaneC = cPlanes;
            Planes = new Plane[cPlanes];
        }
        
        public void Fill() // Функция диаологового заполнения
        {
            string NamePlane;
            int maxspeed;
            int maxfly;
            try
            {
                for (int i = 0; i < this.PlaneC; i++)
                {
                    
                    Console.WriteLine("Введите название самолёта:");
                    NamePlane = Console.ReadLine();
                    Console.WriteLine("Введите максимальную скорость:");
                    maxspeed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите максимальную дальность полёта:");
                    maxfly = Convert.ToInt32(Console.ReadLine());
                    this.Planes[i] = new Plane(NamePlane, maxspeed, maxfly);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Введите данные заново:");
                Fill();
            }
        }

        public void Sort() // Функция сортировки
        {
            Console.WriteLine("Введите размер массива");
            int massize = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[massize];

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Введите массив:");
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            

            Array.Sort(this.Planes);

            
            
        }
    }
}
     
