using AnimalFarm.DAL.DAO;
using AnimalFarm.DAL.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.BLL
{
    internal class CattleBLL
    {
        public static void LoadCattleInformation(ref Cattle cattle, string type)
        {
            CattleDAO.LoadCattleInformation(ref cattle, type);
        }
        public static void breed(Cattle cattle, ref int num)
        {
            int offspring = 0;
            for (int i = 0; i < num; i++)
                offspring += cattle.breed();
            num += offspring; 
        }
        public static float giveMilk(Cattle cattle, int num)
        {
            float totalMilk = 0;
            for (int i = 0; i < num; i++)
                totalMilk += cattle.giveMilk();
            return totalMilk;
        }
        public static string call(Cattle cattle, int num)
        {
            string callteCall = "";
            for (int i = 0; i < num; i++)
                callteCall += (cattle.call() + " ");
            return callteCall;
        }
    }
}
