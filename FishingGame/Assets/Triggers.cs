using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triggers : MonoBehaviour
{

	public UnityEvent Event;

	void OnTriggerEnter(Collider collider)
	{
		Event.Invoke();
	}

	

	
}
