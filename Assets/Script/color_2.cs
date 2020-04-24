using UnityEngine;
using System.Collections;

public class color_2 : MonoBehaviour {

	// Use this for initialization


	void OnTriggerEnter (Collider other)
	{
		//Destroy (other.gameObject);
		Debug.Log ("I AM COLLIDING NOW");


		if (gameObject.tag == "white")
		{
			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.red;
				gameObject.tag = "red";
			}

			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.green;
				gameObject.tag = "blue";
			}
		}

		if (gameObject.tag == "red")
		{
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.magenta;
				gameObject.tag = "goal 2";


			}

			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.red;
				gameObject.tag = "red";
			}
		}

		if (gameObject.tag == "blue")
		{
			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.magenta;
				gameObject.tag = "goal 2";


			}

			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.blue;
				gameObject.tag = "blue";
			}
		}

		if (gameObject.tag == "goal 2") {
			if (other.gameObject.tag == "goal 2") {
				//GetComponent<Renderer> ().material.color = Color.red;
				//gameObject.tag = "red";
				Destroy (gameObject);		
				Application.LoadLevel("3");
			}
		}


		if (other.gameObject.name == "obstacle 1") 
		{
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}
		if (other.gameObject.name == "obstacle 3") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}
		if (other.gameObject.name == "obstacle 4") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}if (other.gameObject.name == "obstacle 5") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}if (other.gameObject.name == "obstacle 7") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}if (other.gameObject.name == "obstacle 8") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}if (other.gameObject.name == "obstacle 9") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}
		if (other.gameObject.name == "obstacle 6") {
			Destroy (gameObject);
			Application.LoadLevel("over2");
		}
	}


}


