using System;
using System.Collections.Generic;
using System.Text;
using GOF_Patterns_Basic.Creational_Patterns.Factory_Method.Classes;

namespace GOF_Patterns_Basic.Creational_Patterns.Factory_Method
{
    class Factory
    {
        public static IMonster GetMonster(string MonsterName)
        {
            IMonster ReturnedValue = null;

            switch (MonsterName)
            {
                case "Goblin":
                    ReturnedValue = new Goblin();
                    break;
                case "Orc":
                    ReturnedValue = new Orc();
                    break;
                case "Rat":
                    ReturnedValue = new Rat();
                    break;
                default:
                    ReturnedValue = new EmptyMonster();
                break;
            }

            return ReturnedValue;
        }
    }
}
