using UnityEngine;
using System.Collections;

public class controls : MonoBehaviour {

	private float speed = 15;
	
	void Start () {
		
	}

	void Update () {

				//if (PlayerPrefs.GetString ("status") == "playing") {
						if (Input.GetKey (KeyCode.UpArrow))
			{
				Debug.Log("UpArrow Press");
				GetComponent<Rigidbody> ().AddForce (Vector3.forward * speed, ForceMode.Force);
			}
		
						if (Input.GetKey (KeyCode.DownArrow))
							GetComponent<Rigidbody> ().AddForce (-Vector3.forward * speed, ForceMode.Force);
		
						if (Input.GetKey (KeyCode.RightArrow))
								GetComponent<Rigidbody> ().AddForce (-Vector3.left * speed, ForceMode.Force);
						//rigidbody.AddTorque(0,speed,0);
		
						if (Input.GetKey (KeyCode.LeftArrow))
								GetComponent<Rigidbody> ().AddForce (Vector3.left * speed, ForceMode.Force);
						//rigidbody.AddTorque(0,-speed,0);

						if (Input.GetKeyDown (KeyCode.Space))
								GetComponent<Rigidbody> ().AddForce (Vector3.up * speed * 10, ForceMode.Force);

       

    }
    public void MoveLeft() {
        GetComponent<Rigidbody>().AddForce(Vector3.left * speed * 10, ForceMode.Force);
    }

    public void MoveRight() {
        GetComponent<Rigidbody>().AddForce(-Vector3.left * speed * 10, ForceMode.Force);
    }

    public void TouchAny() {
        GetComponent<Rigidbody>().AddForce(Vector3.up * speed * 30, ForceMode.Force);
    }
    }
		


