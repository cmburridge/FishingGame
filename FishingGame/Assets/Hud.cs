using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Hud : MonoBehaviour
{

	public GameObject messagePanel;
	
	
	void Start () {
		
	}
	
	
	void Update () {
		
	}

	public void OpenMessagePanel(string text)
	{
		messagePanel.SetActive(true);
		
		
	}

	public void CloseMessagePanel()
	{
		messagePanel.SetActive(false);
	}
}
