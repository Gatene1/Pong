using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float speed = 1.0f;
    private Rigidbody rb;
    private Vector3 storedVelocity;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(1.0f, 1.0f, 0.0f);
        rb.velocity = rb.velocity * speed;
	}
	
	// Update is called once per frame
	void Update () {
        storedVelocity = rb.velocity;
	}

    private void OnCollisionEnter(Collision other)
    {
        rb.velocity = Vector3.Reflect(storedVelocity, other.contacts[0].normal);
    }
}
