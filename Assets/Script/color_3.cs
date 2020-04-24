using UnityEngine;
using System.Collections;

public class color_3 : MonoBehaviour {

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

			if (other.gameObject.tag == "green") 
			{
				GetComponent<Renderer> ().material.color = Color.green;
				gameObject.tag = "green";
			}
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.blue;
				gameObject.tag = "blue";
			}

		}

		if (gameObject.tag == "red")
		{
			if (other.gameObject.tag == "green") 
			{
				GetComponent<Renderer> ().material.color = Color.yellow;
				gameObject.tag = "yellow";
			}

			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.red;
				gameObject.tag = "red";
			}
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.magenta;
				gameObject.tag = "magenta";
			}
		}

		if (gameObject.tag == "green")
		{
			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.yellow;
				gameObject.tag = "yellow";
			}

			if (other.gameObject.tag == "green") 
			{
				GetComponent<Renderer> ().material.color = Color.green;
				gameObject.tag = "green";
			}
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.cyan;
				gameObject.tag = "cyan";
			}
		}

		if (gameObject.tag == "blue")
		{
			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.magenta;
				gameObject.tag = "magenta";
			}

			if (other.gameObject.tag == "green") 
			{
				GetComponent<Renderer> ().material.color = Color.cyan;
				gameObject.tag = "cyan";
			}
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.blue;
				gameObject.tag = "blue";
			}
		}
		//
		if (gameObject.tag == "magenta")
		{
			if (other.gameObject.tag == "green") 
			{
				GetComponent<Renderer> ().material.color = Color.black;
				gameObject.tag = "black";
			}
}//
		if (gameObject.tag == "yellow")
		{
			if (other.gameObject.tag == "blue") 
			{
				GetComponent<Renderer> ().material.color = Color.black;
				gameObject.tag = "black";
			}
		}

		//
		if (gameObject.tag == "cyan")
		{
			if (other.gameObject.tag == "red") 
			{
				GetComponent<Renderer> ().material.color = Color.black;
				gameObject.tag = "black";
			}
		}


		if (gameObject.tag == "black") {
			if (other.gameObject.tag == "goal 3") {
				//GetComponent<Renderer> ().material.color = Color.red;
				//gameObject.tag = "red";
				Destroy (gameObject);			
				Application.LoadLevel("clear");
			}
		}



		if (other.gameObject.name == "obstacle 1") 
		{
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}
		if (other.gameObject.name == "obstacle 3") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}
		if (other.gameObject.name == "obstacle 4") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}if (other.gameObject.name == "obstacle 5") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}if (other.gameObject.name == "obstacle 7") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}if (other.gameObject.name == "obstacle 8") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}if (other.gameObject.name == "obstacle 9") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}
		if (other.gameObject.name == "obstacle 6") {
			Destroy (gameObject);
			Application.LoadLevel("over3");
		}
	}


}

// gljrkghr