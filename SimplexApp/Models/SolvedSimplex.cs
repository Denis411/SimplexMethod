using System;
using System.Collections.Generic

namespace SimplexApp.Models
{
    public struct SolvedSimplex
    {
        public UserData fromData;
        public double value;
        public List<double> variables = new List<double>();
        public List<string> variablesToString
        {
            get
            {
                return doubleToString(variables);
            }
        };

        public SolvedSimplex(UserData data, double value, double[] variables)
        {
            this.fromData = data;
            this.value = value;
            this.variables = variables;
        }

        private List<string> doubleToString(double[] vs)
        {
            List<string> strings = new List<string>();
            foreach(double item in vs) {
                strings.Add(item.ToString);
            }
            return strings;
        }
    }
}
