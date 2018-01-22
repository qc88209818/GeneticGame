/***
 * 怪物-基础类
 */
using UnityEngine;
using System;

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

	public Gane getOrigGane() {
		return _origGane;
	}

	public Gane getSurfGane() {
		return _surfGane;
	}

	public void print() {
		string text = "Orig: -";
		for (int i = 0; i < Gane.GANE_SIZE; ++i) 
		{
			text += _origGane[i] + "-";
		}
		Debug.Log(text);

		string text2 = "Surf -";
		for (int i = 0; i < Gane.GANE_SIZE; ++i) 
		{
			text2 += _surfGane[i] + "-";
		}
		Debug.Log(text2);
	}
}

