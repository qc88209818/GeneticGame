/***
 * 怪物-基础类
 */
using UnityEngine;
using System;

public class Monster : Object {
	Gene _origGene;		// 自己原始基因
	Gene _surfGene;		// 自己表现基因
	int _birthtime;	// 出生时间

	public Monster (Gene gene, int time)
	{
		_origGene = gene;
		_surfGene = gene;
		_birthtime = time;
	}

	public Gene getOrigGene() {
		return _origGene;
	}

	public Gene getSurfGene() {
		return _surfGene;
	}

	public void print() {
		string text = "Orig: -";
		for (int i = 0; i < Gene.GANE_SIZE; ++i) 
		{
			text += _origGene[i] + "-";
		}
		Debug.Log(text);
	}
}

