using System;

namespace SimplexApp.Models
{

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
