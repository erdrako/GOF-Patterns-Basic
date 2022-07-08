using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_Patterns_Basic.Creational_Patterns.Singleton
{
    public class Singleton
    {

        #region Variables

        private static Singleton Instance;

        #endregion

        #region Properties

        #endregion

        #region Constructors
        private Singleton() { }

        #endregion

        #region Functions
        public static Singleton Getinstance()
        {
            if (Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }

        public void DoAction()
        {
            Console.Write("Action Done");
        }

        #endregion

    }
}
