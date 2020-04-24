using UnityEngine;
using System.Collections;

public class COLOR : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		//Destroy (other.gameObject);
		Debug.Log ("I AM COLLIDING NOW");
	

		if (gameObject.tag == "white") {
			if (other.gameObject.tag == "red") {
				GetComponent<Renderer> ().material.color = Color.red;
				gameObject.tag = "goal 1";
			}
		}
		if (gameObject.tag == "goal 1") {
			if (other.gameObject.tag == "goal 1") {
				//GetComponent<Renderer> ().material.color = Color.red;
				//gameObject.tag = "red";
				//Destroy (gameObject);		

			
					Application.LoadLevel("2");
				
			}
		}

		// the obstacles 
		
		if (other.gameObject.name == "obstacle 1") 
		{
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}
		if (other.gameObject.name == "obstacle 2") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}
		if (other.gameObject.name == "obstacle 3") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}
		if (other.gameObject.name == "obstacle 4") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}if (other.gameObject.name == "obstacle 5") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}if (other.gameObject.name == "obstacle 7") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}if (other.gameObject.name == "obstacle 8") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}if (other.gameObject.name == "obstacle 9") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}
		if (other.gameObject.name == "obstacle 6") {
			Destroy (gameObject);
			Application.LoadLevel("over1");
		}
	}

		}

// ljhrlhew