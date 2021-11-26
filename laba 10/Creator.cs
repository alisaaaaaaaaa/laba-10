using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace laba_10
{
    class Creator
    {
        public static Hashtable hashtable = new Hashtable();
        static Creator()
        {
            hashtable = new Hashtable();
        }
        public static void CreateBuilding()
        {
            Building building = new Building();
            building.GetID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CreateBuilding(int Height)
        {
            Building building = new Building();
            building.GetID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CreateBuilding(int Height, int FloorsNumber, int countOfApartments)
        {
            Building building = new Building();
            building.GetID();
            hashtable.Add(SHA256.Create(), building);
        }
        public static void CloseAccount(long id)
        {
            hashtable.Remove(id);
        }
    }
}
