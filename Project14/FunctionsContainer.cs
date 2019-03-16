using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate double CalcDelegate(double x);
class FunctionsContainer
    {
    private Dictionary<string, CalcDelegate> functions;
    public FunctionsContainer()
    {
        functions = new Dictionary<string, CalcDelegate>();
    }
    public CalcDelegate this [string key]
    {
        get
        {
            if(functions.ContainsKey(key))
            {
                return functions[key];
            }
            else
            {
                functions[key] = val => val;
                return functions[key];
            }
        }
        set
        {
            functions[key] = value;
        }
    }

    public void PrintAllFunctions()
    {
        foreach(KeyValuePair<string, CalcDelegate> entry in functions)
        {
            Console.WriteLine("The name is {0} and the value for 2 is {1}", entry.Key, entry.Value(2));
        }
    }

    }
