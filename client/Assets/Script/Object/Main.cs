using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
	private MonsterManager _mgr = MonsterManager.Inst();
	private GeneAlgorithm _algo = GeneAlgorithm.Inst();

	Text _txt_parent; 
	Text _txt_mother; 
	Text _txt_children; 

	// Use this for initialization
	void Start ()
	{
		int time = (int) Time.GetTimeStamp();
		Gene pgene = _algo.randomGene (time+1);
		Gene mgene = _algo.randomGene (time+2);
		Gene cgene = _algo.createGene (pgene, mgene, time);

		GameObject pTrans = GameObject.Find ("TxtParentGene");
		_txt_parent = pTrans.GetComponent<Text> ();
		_txt_parent.text = pgene.getOrigGeneText ();

		GameObject mTrans = GameObject.Find ("TxtMotherGene");
		_txt_mother = mTrans.GetComponent<Text> ();
		_txt_mother.text = mgene.getOrigGeneText ();

		GameObject cTrans = GameObject.Find ("TxtChildrenGene");
		_txt_children = cTrans.GetComponent<Text> ();
		_txt_children.text = cgene.getOrigGeneText ();
	}
}


