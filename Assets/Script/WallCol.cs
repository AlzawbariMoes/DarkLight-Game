using UnityEngine;
using System.Collections;

public class WallCol : MonoBehaviour {

	void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("-100");
	}
	
	void OnCollisionStay(Collision collision)
	{

	}
	
	void OnCollisionExit(Collision collision)
	{

	}
}
