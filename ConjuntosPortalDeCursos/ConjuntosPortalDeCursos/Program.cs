using System.Collections.Generic;


namespace ConjuntosPortalDeCursos
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> setA = new HashSet<int>();
            HashSet<int> setB = new HashSet<int>();
            HashSet<int> setC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= n; i++)
            {
                setA.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                setB.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                setC.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> ABC = new HashSet<int>(setA);
            ABC.UnionWith(setB);
            ABC.UnionWith(setC);

            Console.WriteLine("Total students: " + ABC.Count);
        }
    }
}