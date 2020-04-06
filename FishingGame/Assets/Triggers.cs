using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

public class Triggers : MonoBehaviour
{


	private void OnTriggerEnter2D(Collider2D lure)
	{
		if (lure.tag == "Player")
		{
			Destroy(gameObject);
		}
	}


}
