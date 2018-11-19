using System.Collections;
using System.Collections.Generic;
using XboxCtrlrInput;

using UnityEngine;

public class MovementScript : MonoBehaviour {

   public float Speed;
    public XboxController Controller;
    public Rigidbody EnemyRigidBody;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (XCI.GetAxis(XboxAxis.LeftStickY, Controller) > 0)
        {
            transform.position += new Vector3(0, 0, Speed) * Time.deltaTime;

        }
        if (XCI.GetAxis(XboxAxis.LeftStickY, Controller) < 0)
        {
            transform.position += new Vector3(0, 0, -Speed) * Time.deltaTime;
        }
        if (XCI.GetAxis(XboxAxis.LeftStickX, Controller) < 0)
        {
            transform.position += new Vector3(-Speed, 0, 0) * Time.deltaTime;
        }
        if (XCI.GetAxis(XboxAxis.LeftStickX, Controller) > 0)
        {
            transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player2" && XCI.GetButton(XboxButton.B, Controller))
        {
            EnemyRigidBody.AddForce(new Vector3(50, 100, 0));
        }
    }
}
