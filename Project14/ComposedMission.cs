using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

    class ComposedMission : IMission
    {
    private List<CalcDelegate> funcList;
        public string Name { get; }
        public string Type { get; }
        public ComposedMission(string name)
    {
        Name = name;
        Type = "Composed";
        funcList = new List<CalcDelegate>();
    }
        public event EventHandler<double> OnCalculate;
        public void Add(CalcDelegate d)
    {
        funcList.Add(d);
    }
        public double Calculate(double value)
        {
            foreach del in funcList {

        }
        }
    }

