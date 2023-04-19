using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_Epifanov
{
    public class Plane
    {
        
        public string NamePlane;
        public int maxspeed;
        public int maxfly;

        public Plane(string NamePlane, int maxspeed, int maxfly) // Тип для хранения данных
        {
            this.NamePlane = NamePlane;
            this.maxspeed = maxspeed;
            this.maxfly = maxfly;
        }

        public string ToString() // Данные массива которые переводятся в текстовый файл
        {
            return string.Format("Название самолёта: {0}  Крейсерская скорость: {1} Максимальная дальность полёта: {2}", NamePlane, maxspeed, maxfly);
        }

       


    }
}
