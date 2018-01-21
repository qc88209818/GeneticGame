/***
 * 怪物-基础类
 */
public class Monster : Object {
	Gane _origGane;		// 自己原始基因
	Gane _surfGane;		// 自己表现基因
	int _birthtime;	// 出生时间

	public Monster (Gane gane, int time)
	{
		_origGane = gane;
		_surfGane = gane;
		_birthtime = time;
	}
}

