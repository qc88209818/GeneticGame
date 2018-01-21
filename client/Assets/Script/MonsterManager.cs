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

	public Monster createMonster(Gane fgane, Gane mgane) {
		int time = getDateTime();
		Gane gane =_algorithm.createGane(fgane, mgane, time);
		return new Monster(gane, time);
	}

	private int getDateTime() {
		DateTime dt = new DateTime();
		return dt.Second;
	}
}

