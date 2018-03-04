using  UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ConfigItems : IBaseDataObject{
	private int _id;
	public int id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}
	public string name{get;set;}
	public string type{get;set;}
	private int _price;
	public int price
	{
		get
		{
			return _price;
		}
		set
		{
			_price = value;
		}
	}
	private int _weight;
	public int weight
	{
		get
		{
			return _weight;
		}
		set
		{
			_weight = value;
		}
	}
	public bool isBroken{get;set;}
	public bool isCatch{get;set;}
	public string resName{get;set;}
	private int _effectiverange;
	public int effectiveRange
	{
		get
		{
			return _effectiverange;
		}
		set
		{
			_effectiverange = value;
		}
	}
	public string describle{get;set;}


	public static ConfigItems[] datas = new ConfigItems[16];
	public static Dictionary<int,ConfigItems> map = new Dictionary<int, ConfigItems> ();

	public static ConfigItems GetByKey (int key){
		ConfigItems data;
		if (map.TryGetValue (key, out data)) {
			return data;
		} else {
			return null;
		}
	}
	static ConfigItems (){

		datas [0] = new ConfigItems ();
		datas [0].id = 10000;
		datas [0].name = "小型金矿";
		datas [0].type = "Ore";
		datas [0].price = 150;
		datas [0].weight = 5;
		datas [0].isBroken = true;
		datas [0].isCatch = true;
		datas [0].resName = "gold_1";
		datas [0].effectiveRange = 0;
		datas [0].describle = "按大小区分，越大越值钱";

		map.Add (datas [0].id,datas [0]);

		datas [1] = new ConfigItems ();
		datas [1].id = 10001;
		datas [1].name = "中型金矿";
		datas [1].type = "Ore";
		datas [1].price = 250;
		datas [1].weight = 10;
		datas [1].isBroken = true;
		datas [1].isCatch = true;
		datas [1].resName = "gold_2";
		datas [1].effectiveRange = 0;
		datas [1].describle = "按大小区分，越大越值钱";

		map.Add (datas [1].id,datas [1]);

		datas [2] = new ConfigItems ();
		datas [2].id = 10002;
		datas [2].name = "大型金矿";
		datas [2].type = "Ore";
		datas [2].price = 500;
		datas [2].weight = 20;
		datas [2].isBroken = true;
		datas [2].isCatch = true;
		datas [2].resName = "gold_3";
		datas [2].effectiveRange = 0;
		datas [2].describle = "按大小区分，越大越值钱";

		map.Add (datas [2].id,datas [2]);

		datas [3] = new ConfigItems ();
		datas [3].id = 10003;
		datas [3].name = "小石头";
		datas [3].type = "Ore";
		datas [3].price = 10;
		datas [3].weight = 10;
		datas [3].isBroken = true;
		datas [3].isCatch = true;
		datas [3].resName = "stone_1";
		datas [3].effectiveRange = 0;
		datas [3].describle = "笨重且不值钱的障碍物";

		map.Add (datas [3].id,datas [3]);

		datas [4] = new ConfigItems ();
		datas [4].id = 10004;
		datas [4].name = "中石头";
		datas [4].type = "Ore";
		datas [4].price = 20;
		datas [4].weight = 20;
		datas [4].isBroken = true;
		datas [4].isCatch = true;
		datas [4].resName = "stone_2";
		datas [4].effectiveRange = 0;
		datas [4].describle = "笨重且不值钱的障碍物";

		map.Add (datas [4].id,datas [4]);

		datas [5] = new ConfigItems ();
		datas [5].id = 10005;
		datas [5].name = "大石头";
		datas [5].type = "Ore";
		datas [5].price = 30;
		datas [5].weight = 30;
		datas [5].isBroken = true;
		datas [5].isCatch = true;
		datas [5].resName = "stone_3";
		datas [5].effectiveRange = 0;
		datas [5].describle = "笨重且不值钱的障碍物";

		map.Add (datas [5].id,datas [5]);

		datas [6] = new ConfigItems ();
		datas [6].id = 10006;
		datas [6].name = "钻石";
		datas [6].type = "Ore";
		datas [6].price = 800;
		datas [6].weight = 5;
		datas [6].isBroken = true;
		datas [6].isCatch = true;
		datas [6].resName = "diamond";
		datas [6].effectiveRange = 0;
		datas [6].describle = "值钱的小石头";

		map.Add (datas [6].id,datas [6]);

		datas [7] = new ConfigItems ();
		datas [7].id = 10007;
		datas [7].name = "小猪";
		datas [7].type = "actor";
		datas [7].price = 10;
		datas [7].weight = 5;
		datas [7].isBroken = true;
		datas [7].isCatch = true;
		datas [7].resName = "pig";
		datas [7].effectiveRange = 0;
		datas [7].describle = "移动迅速的地下生物，能被钩子抓住";

		map.Add (datas [7].id,datas [7]);

		datas [8] = new ConfigItems ();
		datas [8].id = 10008;
		datas [8].name = "炸药桶";
		datas [8].type = "ExplosivesBarrel";
		datas [8].price = 0;
		datas [8].weight = 5;
		datas [8].isBroken = true;
		datas [8].isCatch = true;
		datas [8].resName = "ExplosivesBarrel";
		datas [8].effectiveRange = 0;
		datas [8].describle = "被触碰到就会爆炸的可怕道具";

		map.Add (datas [8].id,datas [8]);

		datas [9] = new ConfigItems ();
		datas [9].id = 10009;
		datas [9].name = "骨头";
		datas [9].type = "Ore";
		datas [9].price = 0;
		datas [9].weight = 5;
		datas [9].isBroken = true;
		datas [9].isCatch = true;
		datas [9].resName = "bone";
		datas [9].effectiveRange = 0;
		datas [9].describle = "不值钱的地下道具";

		map.Add (datas [9].id,datas [9]);

		datas [10] = new ConfigItems ();
		datas [10].id = 10010;
		datas [10].name = "布袋";
		datas [10].type = "RandomBags";
		datas [10].price = 0;
		datas [10].weight = 5;
		datas [10].isBroken = true;
		datas [10].isCatch = true;
		datas [10].resName = "RandomBags";
		datas [10].effectiveRange = 0;
		datas [10].describle = "里面装着随机道具的袋子";

		map.Add (datas [10].id,datas [10]);

		datas [11] = new ConfigItems ();
		datas [11].id = 10011;
		datas [11].name = "炸药";
		datas [11].type = "Explosives";
		datas [11].price = 0;
		datas [11].weight = 5;
		datas [11].isBroken = true;
		datas [11].isCatch = true;
		datas [11].resName = "Explosives";
		datas [11].effectiveRange = 0;
		datas [11].describle = "炸掉钩子上的物品，快速收回钩子";

		map.Add (datas [11].id,datas [11]);

		datas [12] = new ConfigItems ();
		datas [12].id = 10012;
		datas [12].name = "强力药剂";
		datas [12].type = "PowerfulMedicine";
		datas [12].price = 0;
		datas [12].weight = 5;
		datas [12].isBroken = true;
		datas [12].isCatch = true;
		datas [12].resName = "PowerfulMedicine";
		datas [12].effectiveRange = 1;
		datas [12].describle = "加快你收回钩子的速度，一局内有效";

		map.Add (datas [12].id,datas [12]);

		datas [13] = new ConfigItems ();
		datas [13].id = 10013;
		datas [13].name = "石头收藏书";
		datas [13].type = "StoneBook";
		datas [13].price = 0;
		datas [13].weight = 5;
		datas [13].isBroken = true;
		datas [13].isCatch = true;
		datas [13].resName = "StoneBook";
		datas [13].effectiveRange = 1;
		datas [13].describle = "提高你收集到的石头价值，一局内有效";

		map.Add (datas [13].id,datas [13]);

		datas [14] = new ConfigItems ();
		datas [14].id = 10014;
		datas [14].name = "钻石收藏书";
		datas [14].type = "DiamondBook";
		datas [14].price = 0;
		datas [14].weight = 5;
		datas [14].isBroken = true;
		datas [14].isCatch = true;
		datas [14].resName = "DiamondBook";
		datas [14].effectiveRange = 1;
		datas [14].describle = "你搜集到的钻石将会更值钱，一局内有效";

		map.Add (datas [14].id,datas [14]);

		datas [15] = new ConfigItems ();
		datas [15].id = 10015;
		datas [15].name = "幸运草";
		datas [15].type = "Clover";
		datas [15].price = 0;
		datas [15].weight = 5;
		datas [15].isBroken = true;
		datas [15].isCatch = true;
		datas [15].resName = "Clover";
		datas [15].effectiveRange = 1;
		datas [15].describle = "可以从布袋中获得更好的道具，一局内有效";

		map.Add (datas [15].id,datas [15]);
	}
}