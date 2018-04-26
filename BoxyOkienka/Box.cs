using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxyOkienka
{
    class Box
    {
        public static int HowMuch { get; private set; }
        public static List<int> Boxes = new List<int>();
        static Random random = new Random();


        public static string CreateBox(int x)
        {
            Boxes.Clear();
            HowMuch = x;
            int r = random.Next(0, x-1);
            int r2 = random.Next(0, 2);


            for(int i = 0; i<HowMuch; i++)
                Boxes.Add(random.Next(10, 20));
            

            if (r2 == 0)
            Boxes[r] = random.Next(0, 9);
            else
            Boxes[r] = random.Next(21, 100);

            return ("Boxy wylosowane... Wyszukaj pudełka.\n");

        }
        public static string ShowBox()
        {
            string all = "";
            for (int i = 0; i < HowMuch; i++)
                all += Convert.ToString(Boxes[i] + "\n");
            
            return all;
        }

        public static string SearchBox()
        {
            int Id_box = 0;
            int Value_box = 0;
            for (int i = 0; i < HowMuch; i++)
            {
                if (Boxes[i] < 10 || Boxes[i] > 20)
                {
                    Id_box = i + 1;
                    Value_box = Boxes[i];
                    break;
                }
            }
            return Convert.ToString(("Czarne pudelko to pudelko numer: " + Id_box + " i ma wartosc " + Value_box +"\n"));
        }
    }
}
