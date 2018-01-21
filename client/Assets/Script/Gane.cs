/***
 * 基因-基础类
 */
using UnityEngine;

public class Gane {
	public static int GANE_SIZE = 8;
	public static int GANE_CELL_MAX = 32;

	public uint[] gane = new uint[GANE_SIZE];
	public int birthtime = 0;	// 出生时间

	public Gane (uint[] g, int t)
	{
		gane = g;
		birthtime = t;
	}

	public Gane (Gane g)
	{
		gane = g.gane;
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
