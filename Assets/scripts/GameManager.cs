using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameEnded=false;
	public float restarDelay=5f;
	public GameObject completeLevelUI;
	public Text EndScore;
	public GameObject FailedLevelUI;
	public void CompleteLevel(string text){
		EndScore.text="Score: "+text;
		completeLevelUI.SetActive(true);
	}
	public void FailLevel(){
		FailedLevelUI.SetActive(true);
	}
	public void EndGame() {
		if(!gameEnded){
			gameEnded=true;
			Debug.Log("gameover");
			FailLevel();
			Invoke("Restart",restarDelay);
		}
	}

	void Restart(){
		FailedLevelUI.SetActive(false);
		Application.LoadLevelAsync("menu");
	}

}
