using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Score : MonoBehaviour {
	
	public Transform player;
	public Text scoretext;

	float startTime =0;
	bool init=true;

	void Update () {

		if(init){
			init=false;
			startTime=Time.time;
		}

		if(player.hasChanged){
			float k=Time.time;
			scoretext.text=((int)(k-startTime)).ToString();
		}
	}
}
