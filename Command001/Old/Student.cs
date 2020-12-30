using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Old
{
    class Student
    {
        public void Execute()
        {
            //水100gに食塩を1gずつ加えて飽和食塩水を作る実験
            Beaker beaker = new Beaker(100, 0);
            beaker.experiment(Beaker.ADD_SALT);

            //食塩10gに水を10gずつ加えて飽和食塩水を作る実験
            Beaker beaker2 = new Beaker(0, 10);
            beaker2.experiment(Beaker.ADD_WATER);

            //10%の食塩水100gを作る実験
            Beaker beaker3 = new Beaker(90, 10);
            beaker3.experiment(Beaker.MAKE_SALT_WATER);
        }
    }
}
