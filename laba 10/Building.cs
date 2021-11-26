using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_10
{
    class Building
    {
        private static int ID = 1;
        private long Number;
        private int FloorsNumber;
        private int Height;
        private int ApartmentsNumber;
        public long GetID()
        {
            return ID++;
        }
        internal Building()
        {
            Number = GetID();
        }
        internal Building(int Height)
        {
            Number = GetID();
            this.Height = Height;
        }
        internal Building(int Height, int FloorsNumber, int ApartmentsNumber)
        {
            Number = GetID();
            this.Height = Height;
            this.FloorsNumber = FloorsNumber;
            this.ApartmentsNumber = ApartmentsNumber;
        }
        public double FloorHeight(int Height, int FloorsNumber)
        {
            Console.WriteLine("Введите высоту здания");
            while (!int.TryParse(Console.ReadLine(), out Height))
            {
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine("Введите количество этажей в здании");
            while (!int.TryParse(Console.ReadLine(), out FloorsNumber))
            {
                Console.WriteLine("Ошибка!");
            }
            double FloorsHeight;
            if (FloorsNumber != 0)
            {
                FloorsHeight = Height / FloorsNumber;
            }
            else
            {
                FloorsHeight = Height;
            }
            return FloorsHeight;
        }
        public int ApartmentsOnFloor(int ApartmentsNumber, int FloorsNumber)
        {
            Console.WriteLine("Введите количество квартир");
            while (!int.TryParse(Console.ReadLine(), out Height))
            {
                Console.WriteLine("Ошибка!");
            }
            Console.WriteLine("Введите количество этажей в здании ");
            while (!int.TryParse(Console.ReadLine(), out FloorsNumber))
            {
                Console.WriteLine("Ошибка!");
            }
            int apartmentOnFloors;
            if (FloorsNumber != 0)
            {
                apartmentOnFloors = ApartmentsNumber / FloorsNumber;
            }
            else
            {
                apartmentOnFloors = ApartmentsNumber;
            }
            return apartmentOnFloors;
        }
    }
}
