using UnityEngine;
using System.Collections;

public class boardCol : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		gameObject.GetComponent<Renderer>().material.color = Color.black;
	}
	
	void OnCollisionStay(Collision collision)
	{
		gameObject.GetComponent<Renderer>().material.color = Color.black;
	}

	void OnCollisionExit(Collision collision)
	{
		gameObject.GetComponent<Renderer>().material.color = Color.green;
	}
}
