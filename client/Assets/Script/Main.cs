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
		fgane.print ();

		Gane mgane = _algo.randomGane ();
		mgane.print ();

		DateTime dt = new DateTime ();
		Gane baby = _algo.createGane (fgane, mgane, dt.Second);
		baby.print ();
	}

	// Update is called once per frame
	void Update ()
	{

	}
}


