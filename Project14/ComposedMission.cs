// Alon Levkovitch, 313545931, group 06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Excercise_1
{
    class ComposedMission : IMission
    {
        private List<CalcDelegate> funcList;

        public string Name { get; }

        public string Type { get; }

        public ComposedMission(string name)
        {
            // we just set that name and type.
            Name = name;
            Type = "Composed";
            // initialize the delegate list.
            funcList = new List<CalcDelegate>();
        }
        public event EventHandler<double> OnCalculate;

        public ComposedMission Add(CalcDelegate d)
        {
            // add a delegate to the list, that is set in the order added.
            // we clone the delegate so out mission will not change when the container does.
            funcList.Add((CalcDelegate)d.Clone());
            return this;
        }

        public double Calculate(double value)
        {
            // save an intermidiate value.
            double intermidiate = value;
            // for each delegate calculate its value and pipe it to the next.
            foreach (CalcDelegate del in funcList)
            {
                intermidiate = del(intermidiate);
            }
            // make sure the events isn't null and invoke it.
            OnCalculate?.Invoke(this, intermidiate);
            return intermidiate;
        }
    }
}

