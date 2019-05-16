using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EndTrigger : MonoBehaviour {

	public GameManager GameManager;

	public Text scoreCard;

	void OnTriggerEnter() {
		GameManager.CompleteLevel(scoreCard.text);
	}
}
