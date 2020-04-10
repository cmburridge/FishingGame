using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Detection : MonoBehaviour
{

	public UnityEvent Event;
	
	void OnTriggerEnter2D(Collider2D lure)
	{
		Event.Invoke();
	}
}
