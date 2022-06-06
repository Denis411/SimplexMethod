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

        public SolvedSimplex solveSimplex(UserData userData)
        {
            simplex = new Simplex(userData.)
        }
    }
}