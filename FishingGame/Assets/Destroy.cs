using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroy : MonoBehaviour
{
	

	void Update ()
	{
		if (Input.GetButtonDown("Fire2"))
		{
			Destruction();
		}
	}

	void Destruction()
	{
		Destroy(this.gameObject);
	}
	
	void OnTriggerEnter2D(Collider2D lure)
	{
		if (lure.tag == "Finish")
		{
			Destruction();
		}
		
	}
	
	
}
