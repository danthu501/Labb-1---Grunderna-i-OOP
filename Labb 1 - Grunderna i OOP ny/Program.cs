using System;

namespace Labb_1___Grunderna_i_OOP_ny
{
    public class Circle 
    {
        float _pi = 3.141f;
        int _Radie;
        int _Hight;

        public Circle(int UserInput)
        {
            _Radie = UserInput;
        }
        public float getArea()
        {
            float Area = _Radie * _Radie * _pi;
            return Area;
        }
        public float Circumference()
        {
            float Round = (_Radie + _Radie) * _pi;
            return Round;
        }
        public float Volume(int UserHight)
        {
            _Hight = UserHight;
            float size = getArea() * _Hight;
            return size;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int InputRadie = 5;
            Circle Radie5 = new Circle(InputRadie);
            Circle Radie6 = new Circle(6);


            Console.WriteLine("Om radien är 5 cm på en cirkel blir arean: "+Radie5.getArea()+ " kvadratcentimeter");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Om radien är 6 cm på en cirkel blir arean: "+Radie6.getArea()+ " kvadratcentimeter");
            Console.WriteLine("-------------------------------------");
            Console.Write("Ange radien på en cirkel i jämna cm: ");
            

            int UserRadie = Convert.ToInt32(Console.ReadLine());
            
            Circle Radie = new Circle(UserRadie);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Om radien är " + UserRadie + " cm, är arean på cirkeln " + Radie.getArea() + " kvadratcentimeter");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Om radien är " + UserRadie + " cm, är omkretsen på cirkeln " + Radie.Circumference()+ " cm");
            Console.WriteLine("-------------------------------------");
            Console.Write("Ange höjd på cirkeln så att det blir en cylinder i (ange jämna cm): ");
            int UserHight = int.Parse(Console.ReadLine());
            Console.WriteLine("Om radien är " + UserRadie + " cm och höjden är " + UserHight + " cm, är volymen på cylindern " + Radie.Volume(UserHight) + " kubikcentimeter.");
            Console.WriteLine("-------------------------------------");
            Console.ReadKey();

            Triangel T1 = new Triangel(5, 2);
            Console.WriteLine("En triangel med bredden 5 cm och höjden 2 cm har en area på: ");
            Console.WriteLine(T1.AreaTriangel()+ " kvadratcentimeter"); 
            Console.ReadKey();

        }
    }

}
