using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplexApp.Models
{
    public enum FunctionType
    {
        maximum,
        minimum
    }
    public struct UserData
    {
        public int countOfLimits;
        public int countOfVariables;
        public FunctionType functionType;

        public UserData(int limits, int variables, FunctionType type)
        {
            this.countOfLimits = limits;
            this.countOfVariables = variables;
            this.functionType = type;
        }
    }
}
