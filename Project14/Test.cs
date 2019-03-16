using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Test
{
    static void Main(string[] args)
    {
        FunctionsContainer funcList = new FunctionsContainer();
        funcList["Double"] = val => val * 2;
        funcList["Triple"] = val => val * 3;
        funcList["Square"] = val => val * val;
        funcList["Sqrt"] = val => Math.Sqrt(val);
        funcList["Plus2"] = val => val + 2;
        funcList.PrintAllFunctions();
        IMission mission = new SingleMission(funcList["Double"], "miss1");
        Console.WriteLine("for 2 we get {0} and for 4 we get {1}", mission.Calculate(2), mission.Calculate(4));
        Console.ReadKey();
    }
}
