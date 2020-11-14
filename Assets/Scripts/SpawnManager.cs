using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	const float spawnRangeX = 10;
	const float spawnPosZ = 20;

	private const float startDelay = 2;
	private const float spawnInterval = 1.5f;

	private void Start()
	{
		InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
	}

	private void Update()
	{
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
