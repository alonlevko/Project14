using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SingleMission : IMission
{
    private CalcDelegate func;
    public string Name { get; }
    public string Type { get; }
    public SingleMission(CalcDelegate f, string name)
    {
        Name = name;
        func = f;
        Type = "Single";
    }
    public event EventHandler<double> OnCalculate;

    public double Calculate(double value)
    {
        return func(value);
    }
}
