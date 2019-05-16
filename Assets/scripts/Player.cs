using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization

	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float sidwaysForce = 500f;
	
	// Update is called once per frame
	void FixedUpdate () {

		if(Input.GetKey("w")){
			rb.AddForce(0,0,forwardForce*Time.deltaTime,ForceMode.VelocityChange);
		}
		if(Input.GetKey("s")){
			rb.AddForce(0,0,-forwardForce*Time.deltaTime,ForceMode.VelocityChange);
		}
		if(Input.GetKey("a")){
			rb.AddForce(-sidwaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}
		if(Input.GetKey("d")){
			rb.AddForce(sidwaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
