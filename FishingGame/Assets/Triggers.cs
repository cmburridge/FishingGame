using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;
using UnityEngine.SceneManagement;
public class Triggers : MonoBehaviour
{
	public GameObject splashScreen;
	public Transform fishLocal;
	public Transform anim;
	public GameObject splash;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
	}
	IEnumerator CatchingCoroutine()
		{
			Instantiate(splashScreen);
			yield return new WaitForSeconds(1.5f);
			SceneManager.LoadScene(2);
		}
	void OnTriggerEnter2D(Collider2D lure)
	{
		
		if (lure.tag == "Player")
		{
			Instantiate(splash, fishLocal.position, anim.rotation);
			StartCoroutine(CatchingCoroutine());
		}
		
	}
	
}
