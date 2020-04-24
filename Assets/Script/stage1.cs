using UnityEngine;
using System.Collections;

public class stage1 : MonoBehaviour {

    private float speed = 15;

    void OnMouseDown() {
		Application.LoadLevel("stage1");

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            Vector2 touchPosition = Input.GetTouch(0).position;
            double halfScreen = Screen.width / 2.0;

            //Check if it is left or right?
            if (touchPosition.x < halfScreen)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * speed * 30, ForceMode.Force);
            }
            else if (touchPosition.x > halfScreen)
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * speed * 30, ForceMode.Force);
            }

        }
    }
}
