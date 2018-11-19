using System.Collections;
using System.Collections.Generic;
using XboxCtrlrInput;

using UnityEngine;

public class TestGunScript : MonoBehaviour
{
    public float bulletSpeed = 10;
   public XboxController Controller;
    public Rigidbody EnemyRigidBody; 
    public Rigidbody bullet;
    public GameObject Spawn;

    public float Speed;
    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, Spawn.transform.position, transform.rotation);
        bulletClone.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        if(XCI.GetButtonDown(XboxButton.RightBumper, Controller))
        {
            Fire();
        }
        if (XCI.GetAxis(XboxAxis.RightStickX, Controller) < 0)
        {
            transform.Rotate(0, -Speed, 0) ;

        }
        if (XCI.GetAxis(XboxAxis.RightStickX, Controller) > 0)
        {
            transform.Rotate(0, Speed, 0);

        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            EnemyRigidBody.AddForce(new Vector3(300, 500, 0));
        }
    }
}


