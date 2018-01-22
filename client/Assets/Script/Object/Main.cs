using UnityEngine;
using System;
using System.Collections;

public class Main : MonoBehaviour
{
	private MonsterManager _mgr = MonsterManager.Inst();
	private GaneAlgorithm _algo = GaneAlgorithm.Inst();

	// Use this for initialization
	void Start ()
	{
		Gane fgane = _algo.randomGane ();
		Gane mgane = _algo.randomGane ();
		Monster mm = _mgr.createMonster (fgane, mgane);
		mm.print ();
	}

	// Update is called once per frame
	void Update ()
	{
		
	}
}


