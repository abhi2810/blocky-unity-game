using UnityEngine;
using System.Collections;

public class HomeEvent : MonoBehaviour {

	void OpenMenuPage(){
		Application.LoadLevelAsync("menu");
	}
}
