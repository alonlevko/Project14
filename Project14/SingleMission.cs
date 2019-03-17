// Alon Levkovitch, 313545931, group 06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Excercise_1
{
    public class SingleMission : IMission
    {
        private CalcDelegate func;

        public string Name { get; }

        public string Type { get; }

        // create a single mission based of the delegate and the mission name.
        public SingleMission(CalcDelegate f, string name)
        {
            Name = name;
            func = f;
            Type = "Single";
        }

        public event EventHandler<double> OnCalculate;

        public double Calculate(double value)
        {
            // calculate the result of the delegate.
            double result = func(value);
            // make sure that the event isn't null and then invoke it.
            OnCalculate?.Invoke(this, result);
            return result;
        }
    }
}
