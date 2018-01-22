/***
 * 基因-基础类
 */
using UnityEngine;
using System;

public class Gane {
	public static int GANE_SIZE = 8;
	public static int GANE_CELL_MAX = 32;

	public uint[] gane = new uint[GANE_SIZE];
	public int birthtime = 0;	// 出生时间

	public Gane (Gane g)
	{
		gane = g.gane;
	}

	public Gane (uint[] g, int t)
	{
		gane = g;
		birthtime = t;
	}

	public uint this[int index] {
		//实现索引器的get方法
		get
		{
			if (index < GANE_SIZE)
			{
				return gane[index];
			}
			return 0;
		}

		//实现索引器的set方法
		set
		{
			if (index < GANE_SIZE)
			{
				gane[index] = value;
			}
		}
	}

	public void print() 
	{
		string text = "-";
		for (int i = 0; i < GANE_SIZE; ++i) 
		{
			text += gane[i] + "-";
		}
		Debug.Log(text);
	}
}
