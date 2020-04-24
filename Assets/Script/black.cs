using UnityEngine;
using System.Collections;

public class black : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter (Collider other)
	{
		// white character VS black obstacles
		if (gameObject.tag == "character-white") {
			if (other.gameObject.name == "Black-1") {
				Debug.Log ("I AM COLLIDING NOW");
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-2") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-3") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-4") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-5") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-6") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-7") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-8") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-9") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-10") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-11") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-12") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-13") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "Black-14") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "GameObject") {
				Destroy (gameObject);
				Application.LoadLevel ("clear");
			}
		}

// when white change color to black
		if (gameObject.tag == "character-white") {
			if (other.gameObject.tag == "embty_changing") {
				gameObject.tag = "character-black";
				GetComponent<Renderer> ().material.color = Color.black;
				Debug.Log ("moesiscool");
			}
			}

// Black VS white

		if (gameObject.tag == "character-black") {
			if (other.gameObject.name == "White-1") {
				Debug.Log ("I AM COLLIDING NOW");
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-2") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-3") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-4") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-5") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-6") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-7") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-8") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-9") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-10") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-11") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-12") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "White-13") {
				Destroy (gameObject);
				Application.LoadLevel ("over1");
			}
			if (other.gameObject.tag == "GameObject") {
				Destroy (gameObject);
				Application.LoadLevel ("clear");
			}
		}





	}
}


