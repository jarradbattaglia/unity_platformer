using UnityEngine;
using System.Collections;

public class DestroyOnCollision : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D target) {
		Debug.Log ("COLLISION 2D ENTERED");
		if(target.gameObject.tag == "Deadly" ) {
			if(target.gameObject.layer == LayerMask.NameToLayer("Bullet")) {
				Destroy (target.gameObject);
			}
			OnDestroy();
		}
	}
	
	void OnDestroy() {
		Destroy(gameObject);
	}
}
