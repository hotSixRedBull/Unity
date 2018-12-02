using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {
	Animator anim;
	public Rigidbody2D rb;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool onGround;
	float jumpForce = 700f;

	// Use this for initialization
	void Start () {
			rb = GetComponent<Rigidbody2D>();	
			anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//rb.velocity = new Vector2(3,  rb.velocity.y);
		onGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
		if (Input.GetMouseButtonDown(0) && onGround) {
			rb.AddForce (Vector2.up * jumpForce);
		}
	}



}
