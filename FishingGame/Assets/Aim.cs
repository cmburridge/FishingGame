using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour {

	public float moveSpeed = 5f;

	public Transform otherTransform;
	public Rigidbody2D rod;
	public Camera cam;
	private Vector2 mousePos;
	private Vector2 move;

	private void Start()
	{
		otherTransform = GameObject.Find("Boat").transform;
	}

	void Update () {
		transform.position = new Vector3(otherTransform.position.x, otherTransform.position.y, otherTransform.position.z);
		mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
		
		if (Input.GetButtonDown("Fire1"))
		{
			rod.constraints = RigidbodyConstraints2D.FreezeAll;
		}

		if (Input.GetButtonDown("Fire2"))
		{
			rod.constraints = 0;
		}

	}

	private void FixedUpdate()
	{
		rod.MovePosition(rod.position + move * moveSpeed * Time.fixedDeltaTime);
		Vector2 lookDir = mousePos - rod.position;
		float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg -45f;
		rod.rotation = angle;
	}
}
