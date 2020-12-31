using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod001.Example
{
	//カフェイン飲料
    public abstract class CaffeineBeverage
    {
		public void prepareRecipe()
		{
			boilWater();
			brew();
			pourInCup();
			addCondiments();
		}

		public abstract void brew();

		public abstract void addCondiments();

		//湯を沸かす
		void boilWater()
		{
			Console.WriteLine("湯を沸かす");
		}

		//カップに注ぐ
		void pourInCup()
		{
			Console.WriteLine("カップに注ぐ");
		}
	}
}
