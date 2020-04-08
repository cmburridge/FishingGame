using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;
using UnityEngine.SceneManagement;
public class Triggers : MonoBehaviour
{


	private void OnTriggerEnter2D(Collider2D lure)
	{
		if (lure.tag == "Player")
		{
			SceneManager.LoadScene(1);
		}
	}


}
