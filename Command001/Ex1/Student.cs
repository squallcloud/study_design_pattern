using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.Ex1
{
    //実験する生徒
    public class Student
    {
        public void Execute()
        {
            //実験内容(コマンドオブジェクト)を用意する
            Command makeSaltWater = new MakeSaltWaterCommand();
            Command addSalt = new AddSaltCommand();
            MakeSaltWaterAddSaltCommand makeSaltWaterAddSalt = new MakeSaltWaterAddSaltCommand();
            //実験セットを実験内容にセットする
            Beaker beaker = new Beaker(90, 10);
            makeSaltWater.setBeaker(beaker);
            addSalt.setBeaker(beaker);
            makeSaltWaterAddSalt.setBeaker(beaker);
            //実験リストをセットする
            makeSaltWaterAddSalt.addCommand(makeSaltWater);
            makeSaltWaterAddSalt.addCommand(addSalt);
            //実験を行う
            makeSaltWaterAddSalt.execute();
        }
    }
}
