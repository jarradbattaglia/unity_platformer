using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {
	public float speed = .3f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody2D.velocity = new Vector2(this.transform.localScale.x*speed, rigidbody2D.velocity.y);
	}
}
