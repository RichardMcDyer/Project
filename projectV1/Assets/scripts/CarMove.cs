using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {


	private CharacterController con;
	private Vector3 moveV;
	private float VertVelocity = 0.0f;
	private float gravity = 12.0f;

	private float animationDiration = 3.0f;

	private bool isDead = false;

	private float speed = 3.0f;

	private float HorzSpeed = 2.5f;
	// Use this for initialization
	void Start () {
		con = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (isDead)
			return; 

		if (Time.time < animationDiration) {
			con.Move (Vector3.forward * speed * Time.deltaTime);
			return;
		}
		//reset 
		moveV = Vector3.zero;

		if (con.isGrounded)
		{
			VertVelocity = -0.5f;
		} 
		else 
		{
			VertVelocity -= gravity * Time.deltaTime;
		}

		//x movement (left and right)
		moveV.x = (Input.GetAxisRaw("Horizontal"))* HorzSpeed;

		//y movement (up and down)
		moveV.y = VertVelocity;

		//z movement (foward and backward)

		moveV.z = speed;

		con.Move((moveV* speed) * Time.deltaTime);
	}

	public void setSpeed(float modifier){
		speed = 2.0f + modifier;
	}

	private void OnControllerColliderHit(ControllerColliderHit hit){
		if (hit.point.z > transform.position.z + con.radius)
			Death ();
	}

	private void Death(){
		isDead = true;
		GetComponent<Score> ().OnDeath ();
	} 
}
