using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPushScript : MonoBehaviour {

    public Rigidbody EnemyRigidBody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player2")
        {
            EnemyRigidBody.AddForce(new Vector3(300, 500, 0));
        }
    }
}
