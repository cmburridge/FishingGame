using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;
using UnityEngine.SceneManagement;
public class Triggers : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}

	private void OnTriggerEnter2D(Collider2D lure)
	{
		if (lure.tag == "Player")
		{
			SceneManager.LoadScene(2);
		}
	}


}
