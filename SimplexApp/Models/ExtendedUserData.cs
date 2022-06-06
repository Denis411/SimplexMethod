using System;

namespace SimplexApp.Models
{
    public enum FunctionType
    {
        maximum,
        minimum
    }

    public class ExtendedUserData : UserData
    {
        private UserData userData;
        public int countOfLimits
        {
            get { return userData.countOfLimits }
        }
        public int countOfVariables
        {
            get { return userData.countOfLimits }
        }
    
        public FunctionType functionType
        {
            get { return userData.functionType }
        }

        public ExtendedUserData(UserData data, double[] functionVariables, double[,] allVariables, )
        {

        }
    }
}
