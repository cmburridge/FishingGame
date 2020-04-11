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
	public GameObject noSoundSplash;
	public GameObject menu;
	
	private float nextActionTime = 0.0f;
	public float period = 0.1f;
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene(0);
		}
		StartCoroutine(splashArround());
	}
	IEnumerator CatchingCoroutine()
	{
		Instantiate(splashScreen);
		yield return new WaitForSeconds(1.5f);
		SceneManager.LoadScene(2);
	}

	IEnumerator splashArround()
	{
		yield return new WaitForSeconds(1f);
		if (Time.time > nextActionTime)
		{
			nextActionTime += period;
			Instantiate(noSoundSplash, fishLocal.position, anim.rotation);
		}
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
