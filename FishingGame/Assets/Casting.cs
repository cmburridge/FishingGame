using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Casting : MonoBehaviour
{
	public Transform boat;
	public Transform linePoint;
	public GameObject bobberPrefab;
	public float numBobbers = 0f;
	public float castSpeed = 10f;
	
	void Update () {
		if (Input.GetButtonDown("Fire2"))
		{
			numBobbers --;
			if (numBobbers < 0)
			{
				numBobbers = 0;
			}
		}
		if (numBobbers == 1)
		{
        	return;
		}
		else
		{
			if (Input.GetButtonDown("Fire1"))
			{
				Cast();
			}		
		}

	} 
	

	void Cast()
	{
		GameObject bobber = Instantiate(bobberPrefab, linePoint.position, boat.rotation);
		Rigidbody2D rb = bobber.GetComponent<Rigidbody2D>();
		rb.AddForce(linePoint.up * castSpeed, ForceMode2D.Impulse);
		numBobbers ++;
	}

	
}
