/***
 * 计算基因的算法类（单实例）
 */
using System;

public class GeneAlgorithm {
	static GeneAlgorithm _algorithm = new GeneAlgorithm ();
	public static GeneAlgorithm Inst() {
		return _algorithm;
	}

	public Gene randomGene() {
		DateTime dt = new DateTime ();
		int time = dt.Second;
		return randomGene(time);
	}

	public Gene randomGene(int time) {
		Random rm = new Random (time);

		uint[] baby = new uint[Gene.GANE_SIZE];
		for (int i = 0; i < Gene.GANE_SIZE; ++i) {
			baby [i] = (uint) rm.Next (1, Gene.GANE_CELL_MAX);
		}

		return new Gene (baby, time);
	}

	public Gene createGene(Gene fgane, Gene mgane, int time) {
		return _createGene(fgane, mgane, time);
	}

	private Gene _createGene(Gene _fgane, Gene _mgane, int time) {
		// 随机种子
		Random rm = new Random (time);

		// 孩子基因
		uint[] baby = new uint[Gene.GANE_SIZE];
		for (int i = 0; i < Gene.GANE_SIZE; ++i) {
			if (rm.NextDouble () < 0.5) {
				baby [i] = _mgane [i];
			} else {
				baby [i] = _fgane [i];
			}
		}

		return new Gene (baby, time);
	}
}