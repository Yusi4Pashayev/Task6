namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dairənin radiusunu daxil etdikdən sonra sahəsini və hesabla(mənfi ədəd daxil edilərsə false çap olunsun, 5 daxil edilibsə sahe = 25pi çap olunsun)

            
            while (true)
            {
                Console.WriteLine("Dairenin radiusunu daxil edin:");
                int a = int.Parse(Console.ReadLine());
                if (a == 5) Console.WriteLine("25pi");
                else if (a > 0) Console.WriteLine(a * a + "pi");
                else if (a == 0) Console.WriteLine("ORTADA BIR DAIRE YOXDU!");
                else Console.WriteLine("Menfi eded daxil etmisiz!");
            }
            
        }
    }
}