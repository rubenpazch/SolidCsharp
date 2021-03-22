using System;
using System.Collections.Generic;

namespace SolidCsharp
{
    public enum SomeRootVegetables{
        Peregil,
        Culandro,
        Oregano
    }

    [Flags]
    public enum Seasons{
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 3,
        Spring = 8,
        All = Summer |  Autumn | Winter | Spring
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<SomeRootVegetables, Seasons> AvailableIn = new Dictionary<SomeRootVegetables, Seasons>();
            AvailableIn[SomeRootVegetables.Peregil] = Seasons.Winter;
            AvailableIn[SomeRootVegetables.Culandro] = Seasons.Spring;
            AvailableIn[SomeRootVegetables.Oregano] = Seasons.Autumn;
            Seasons[] theSeasons = new Seasons[] {Seasons.Summer, Seasons.Autumn, Seasons.Winter, Seasons.Spring};
            foreach (Seasons season in theSeasons)
            {
                Console.Write(String.Format("the following root vegetables are harvested in {0}: \n", season.ToString("G")));
                foreach (KeyValuePair<SomeRootVegetables, Seasons> item in AvailableIn)
                {
                    if (((Seasons)item.Value & season)> 0)
                        Console.Write(String.Format(" {0:G}\n", (SomeRootVegetables)item.Key));
                }
            }

        }
    }
}
