using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

      [Header("Movement Stuff")]
    public float moveSpeed;
    public Vector2 directionToMove;
    public Rigidbody2D myRigidBody;


	// Use this for initialization
	void Start () {

        myRigidBody = GetComponent<Rigidbody2D>();
		
	}
	

	

    public void Launch(Vector2 initialVel) {
        myRigidBody.velocity = initialVel * moveSpeed;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
       
    }
}
