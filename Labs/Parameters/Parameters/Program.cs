#region using directives
using System;
#endregion


namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int teri = 0;
            Console.WriteLine(teri);
            Pass.Value(teri);
            Console.WriteLine(teri);
            teri = Pass.setTeri();
            Console.WriteLine(teri);

            Console.WriteLine("---------");

            int i = 0;
            Console.WriteLine($"i is {i}");
            Pass.Value2(ref i);
            Console.WriteLine(i);

            Console.WriteLine("---------");

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);

            Console.WriteLine(wi.Allie);
            Pass.Reference2(wi);
            Console.WriteLine(wi.Allie);

            Console.WriteLine(wi.isTrue);
            Pass.Reference2(wi);
            Console.WriteLine(wi.isTrue);

            Duck daffy = new Duck();
            Console.WriteLine($"Daffy's name is [{daffy.Name}]");
            daffy.Name = "Daffy";
            Console.WriteLine($"Daffy's name is now [{daffy.Name}]");
            daffy.SetName("Daffidil");
            Console.WriteLine($"Daffy's name is now [{daffy.Name}]");

            Duck huey = new Duck();
            huey.SetName("Huey");
            Console.WriteLine(huey.Name);

            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
