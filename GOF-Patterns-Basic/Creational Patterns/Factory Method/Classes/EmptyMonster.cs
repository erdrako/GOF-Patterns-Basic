using System;
using System.Collections.Generic;
using System.Text;

namespace GOF_Patterns_Basic.Creational_Patterns.Factory_Method.Classes
{
    class EmptyMonster : IMonster
    {
        public void Move() { }

        public void Attack() { }
    }
}
