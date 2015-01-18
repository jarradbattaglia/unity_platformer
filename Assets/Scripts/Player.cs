using UnityEngine;
using System.Collections;
using System;

public class Player : MonoBehaviour {
	public float speed = 16f;
	public Vector2 maxVelocity = new Vector2(3,5);
	private Animator animator;
	public float jumpSpeed = 5f;
	public bool standing;
	public GameObject ammo;
	public Transform fireMarker;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	public void Fire() {
		if (ammo != null) {
			var clone = Instantiate(ammo, fireMarker.position,Quaternion.identity) as GameObject;
			clone.transform.localScale = transform.localScale;
		}
	}

	// Update is called once per frame
	void Update () {
		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var absVelY = Mathf.Abs (rigidbody2D.velocity.y);
		var forceX = 0f;
		var forceY = 0f;

		if (absVelY <=.05f) {
			standing = true;
		} else {
			standing = false;
		}

		if (Input.GetKey ("right")) {
			if (absVelX < maxVelocity.x) {
				forceX = speed;
				this.transform.localScale = new Vector3(1,1,1);
				animator.SetInteger("AnimState", 1);
			}
		} else if(Input.GetKey ("left")) {
			if (absVelX < maxVelocity.x) {
				forceX = -speed;
				this.transform.localScale = new Vector3(-1,1,1);
				animator.SetInteger("AnimState", 1);
			}
		} else {
			animator.SetInteger("AnimState", 0);
		}
		if(Input .GetKeyDown("up")&& standing) {
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpSpeed);
		}
		if(Input.GetKey("space") && standing) {
			animator.SetInteger("AnimState", 2);
			rigidbody2D.velocity = Vector2.zero;
		} else {
			rigidbody2D.AddForce(new Vector2(forceX, forceY));
		}
	}
}
