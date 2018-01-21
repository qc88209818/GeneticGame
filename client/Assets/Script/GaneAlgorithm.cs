/***
 * 计算基因的算法类（单实例）
 */
using System;

public class GaneAlgorithm {
	static GaneAlgorithm _algorithm = new GaneAlgorithm ();
	public static GaneAlgorithm Inst() {
		return _algorithm;
	}

	public Gane randomGane() {
		DateTime dt = new DateTime ();
		int time = dt.Second;
		return _randomGane(time);
	}

	public Gane _randomGane(int time) {
		Random rm = new Random ();

		uint[] baby = new uint[Gane.GANE_SIZE];
		for (uint i = 0; i < Gane.GANE_SIZE; ++i) {
			baby [i] = (uint) rm.Next (0, Gane.GANE_CELL_MAX);
		}

		return new Gane (baby, time);
	}

	public Gane createGane(Gane fgane, Gane mgane, int time) {
		return _createGane(fgane, mgane, time);
	}

	private Gane _createGane(Gane fgane, Gane mgane, int time) {
		uint[] _mgane = mgane.gane;
		uint[] _fgane = fgane.gane;

		// 随机种子
		Random rm = new Random (time);

		// 孩子基因
		uint[] baby = new uint[Gane.GANE_SIZE];
		for (uint i = 0; i < Gane.GANE_SIZE; ++i) {
			if (rm.NextDouble () < 0.5) {
				baby [i] = _mgane [i];
			} else {
				baby [i] = _fgane [i];
			}
		}

		return new Gane (baby, time);
	}
}