using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	public Vector3 position;
	public CharacterController controller;
	public float speed = 1f;
	public Animator animator;
	void Start () {
		
	}
	
	void Update ()
	{
		position.x = speed * Input.GetAxis("Horizontal");
		controller.Move(position * Time.deltaTime);
		position.y = speed * Input.GetAxis("Vertical");

		if (Input.GetButtonDown("Down"))
		{
			animator.SetBool("IsDown", true);
		}
	}

	
}
