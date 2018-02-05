/***
 * 怪物-管理类（单实例）
 */
using System;

public class MonsterManager {
	private GeneAlgorithm _algorithm = GeneAlgorithm.Inst();		// 基因 

	static MonsterManager _manager = new MonsterManager ();
	public static MonsterManager Inst() {
		return _manager;
	}

	public Monster createMonster(Monster fmonster, Monster mmonster) {
		int time = (int) Time.GetTimeStamp();
		Gene gene =_algorithm.createGene(fmonster.getOrigGene(), mmonster.getOrigGene(), time);
		return new Monster(gene, time);
	}

	public Monster createMonster(Gene fgene, Gene mgene) {
		int time = (int) Time.GetTimeStamp();
		Gene gene =_algorithm.createGene(fgene, mgene, time);
		return new Monster(gene, time);
	}
}

