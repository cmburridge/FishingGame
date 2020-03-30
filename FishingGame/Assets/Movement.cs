using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public Vector3 position;
	public CharacterController controller;
	public float speed = 1f;
	void Start () {
		
	}
	
	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime);
		position.y = speed * Input.GetAxis("Vertical");
	}
}
