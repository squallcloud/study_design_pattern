using System;
using System.Collections.Generic;
using System.Text;

namespace Command001.New
{
    //実験コマンドのスーパークラス
    public abstract class Command
    {
        //ビーカー
        protected Beaker beaker;
        //ビーカーをセットするメソッド
        public void setBeaker(Beaker beaker)
        {
            this.beaker = beaker;
        }
        //要求内容を実行する抽象メソッド
        public abstract void execute();
    }
}
