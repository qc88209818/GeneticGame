/***
 * 基因-基础类
 */
using UnityEngine;
using System;

public class Gene {
	public static int GANE_SIZE = 8;
	public static int GANE_CELL_MAX = 9;

	public uint[] gene = new uint[GANE_SIZE];
	public int birthtime = 0;	// 出生时间

	public Gene (Gene g)
	{
		gene = g.gene;
	}

	public Gene (uint[] g, int t)
	{
		gene = g;
		birthtime = t;
	}

	public uint this[int index] {
		//实现索引器的get方法
		get
		{
			if (index < GANE_SIZE)
			{
				return gene[index];
			}
			return 0;
		}

		//实现索引器的set方法
		set
		{
			if (index < GANE_SIZE)
			{
				gene[index] = value;
			}
		}
	}

	public string getOrigGeneText() {
		string text = " - ";
		for (int i = 0; i < GANE_SIZE; ++i) 
		{
			text += gene[i] + " - ";
		}
		return text;
	}
		
	public void print() 
	{
		string text = getOrigGeneText ();
		Debug.Log(text);
	}

}
