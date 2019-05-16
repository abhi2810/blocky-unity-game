using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public void Quit(){
		Application.Quit();
	}
	public void Begin(){
		Debug.Log("Begin");
		Application.LoadLevelAsync("blocky");
	}
}
