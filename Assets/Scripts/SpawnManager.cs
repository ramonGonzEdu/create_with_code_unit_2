﻿using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;

	private void Start()
	{

	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			int animalIndex = Random.Range(0, animalPrefabs.Length);
			Instantiate(animalPrefabs[animalIndex],
						new Vector3(0, 0, 20),
						animalPrefabs[animalIndex].transform.rotation);
		}
	}
}
