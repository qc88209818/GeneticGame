/***
 * 怪物-管理类（单实例）
 */
using System;

public class MonsterManager {
	private GaneAlgorithm _algorithm = GaneAlgorithm.Inst();		// 基因 

	static MonsterManager _manager = new MonsterManager ();
	public static MonsterManager Inst() {
		return _manager;
	}

	public Monster createMonster(Monster fmonster, Monster mmonster) {
		int time = (int) Time.GetTimeStamp();
		Gane gane =_algorithm.createGane(fmonster.getOrigGane(), mmonster.getOrigGane(), time);
		return new Monster(gane, time);
	}

	public Monster createMonster(Gane fgane, Gane mgane) {
		int time = (int) Time.GetTimeStamp();
		Gane gane =_algorithm.createGane(fgane, mgane, time);
		return new Monster(gane, time);
	}
}

