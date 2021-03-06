﻿using UnityEngine;
using System.Collections;

public class LookForward : MonoBehaviour {
	public Transform sightStart, sightEnd;
	private bool collision = false;
	public bool needsCollision = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		collision = Physics2D.Linecast(sightStart.position, sightEnd.position, 1 << LayerMask.NameToLayer("Solid"));
		Debug.DrawLine(sightStart.position, sightEnd.position, Color.green);
		if(collision == needsCollision) {
			Debug.Log(collision);
			this.transform.localScale = new Vector3(this.transform.localScale.x*-1,1,1);
		}
	}
}
