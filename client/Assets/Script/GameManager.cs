using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	private GeneAlgorithm _algo = GeneAlgorithm.Inst();

	public void onClickRandom() {
		int time = (int) Time.GetTimeStamp();
		Gene pgene = _algo.randomGene (time+1);
		Gene mgene = _algo.randomGene (time+2);
		Gene cgene = _algo.createGene (pgene, mgene, time);

		GameObject pTrans = GameObject.Find ("TxtParentGene");
		Text _text = pTrans.GetComponent<Text> ();
		_text.text = pgene.getOrigGeneText ();

		GameObject pTrans2 = GameObject.Find ("TxtMotherGene");
		Text _text2 = pTrans2.GetComponent<Text> ();
		_text2.text = mgene.getOrigGeneText ();

		GameObject pTrans3 = GameObject.Find ("TxtChildrenGene");
		Text _text3 = pTrans3.GetComponent<Text> ();
		_text3.text = cgene.getOrigGeneText ();
	}
}
