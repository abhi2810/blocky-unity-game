using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

	void OnCollisionEnter(Collision info) {
		if(info.collider.tag == "obstacle"){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
