using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBlocks : MonoBehaviour {

    public Rigidbody rb;
    public Rigidbody rb1;
   

    public float Force; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            rb.AddForce(new Vector3(0, Force, 0));
        }
        if (collision.gameObject.tag == "Player2")
        {
            rb1.AddForce(new Vector3(0, Force, 0));
        }

    }
}
