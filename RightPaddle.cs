using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPaddle : MonoBehaviour {
    public float speed = 3.0f;
    private Vector3 speedChanger = new Vector3(0.0f, 0.0f, 0.0f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            speedChanger = new Vector3(0.0f, 1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody>().velocity = speedChanger * speed;
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            speedChanger = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().velocity = speedChanger;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            speedChanger = new Vector3(0.0f, -1.0f, 0.0f);
            gameObject.GetComponent<Rigidbody>().velocity = speedChanger * speed;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            speedChanger = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().velocity = speedChanger;
        }
	}
    private void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
    private void OnCollisionExit(Collision other)
    {
        gameObject.GetComponent<Rigidbody>().velocity = speedChanger * speed;
    }
}
