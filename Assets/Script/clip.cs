using UnityEngine;
using System.Collections;



public class clip : MonoBehaviour {


	public bool loop;
	public MovieTexture movTexture;

	void Start() {
		movTexture.loop = true;
		GetComponent<Renderer>().material.mainTexture = movTexture;
		movTexture.Play();


	}

	void Update () 
	{

		//if ( movTexture.isPlaying == false ) {
			//movTexture.Play();
		//}

	}
}