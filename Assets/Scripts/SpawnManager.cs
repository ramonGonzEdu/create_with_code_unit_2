using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	const float spawnRangeX = 20;
	const float spawnPosZ = 20;

	private void Start()
	{

	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			SpawnRandomAnimal();
		}
	}

	private void SpawnRandomAnimal()
	{
		Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
		int animalIndex = Random.Range(0, animalPrefabs.Length);
		Instantiate(animalPrefabs[animalIndex],
					spawnPos,
					animalPrefabs[animalIndex].transform.rotation);
	}
}
