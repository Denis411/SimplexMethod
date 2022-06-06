using System;
using SimplexApp.Models;

namespace SimplexApp.Simplex
{
    public interface ISimplexManager
    {
        public SolvedSimplex solveSimplex(UserData userData);
    }

    public class SimplexManagerDefault: ISimplexManager
    {
        private Simplex simplex;
        public static ISimplexManager sharedInstance = new SimplexManagerDefault();

        private SimplexManagerDefault()
        {

        }

        public SolvedSimplex solveSimplex(ExtendedUserData data)
        {
            simplex = new Simplex(data.functionVariables, data.allVariables, data.freeVariables);
            var result = simplex.maximize();
            SolvedSimplex solvedSimplex = new SolvedSimplex(data, result.Item1, result.Item2);
        }
    }
}