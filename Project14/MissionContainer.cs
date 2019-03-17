// Alon Levkovitch, 313545931, group 06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1
{
    public delegate double CalcDelegate(double x);

    public class FunctionsContainer
    {
        private Dictionary<string, CalcDelegate> functions;

        public FunctionsContainer()
        {
            // create the new dictionary.
            functions = new Dictionary<string, CalcDelegate>();
        }

        public CalcDelegate this[string key]
        {
            get
            {
                // check if we have the key.
                if (functions.ContainsKey(key))
                {
                    // if we have the key return it.
                    return functions[key];
                }
                else
                {
                    // we dont have the key so we create it as an and identity function and return it.
                    functions[key] = val => val;
                    return functions[key];
                }
            }
            set
            {
                functions[key] = value;
            }
        }

        public List<string> getAllMissions()
        {
            // create a new string list that will be returned.
            List<string> list = new List<string>();
            // iterate over each pair in the dictionary and add the key to the list.
            foreach (KeyValuePair<string, CalcDelegate> entry in functions)
            {
                list.Add(entry.Key);
            }
            return list;
        }

    }
}
