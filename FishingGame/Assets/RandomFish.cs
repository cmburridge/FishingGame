using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class RandomFish : MonoBehaviour
{
	public List<GameObject> caughtFish;
	public List<GameObject> fish;
	public int[] table = { 40, 30, 15, 10, 5};


	public int total;
	public int randomNumber;
	private void Start () 
	{
		foreach (var item in table)
		{
			total += item;
		}

		randomNumber = UnityEngine.Random.Range(0, total);

		for (int i = 0; i < table.Length; i++)
		{
			if (randomNumber <= table[i])
			{
				Instantiate(fish[i]);
				caughtFish.Add(fish[i]);
				return;
			}
			else
			{
				randomNumber -= table[i];
			}
		}

		
	}
	
	
}
