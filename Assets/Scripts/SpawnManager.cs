using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] animalPrefabs;
	[Range(0, 2)]
	public int animalIndex;

	private void Start()
	{

	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.S))
		{
			Instantiate(animalPrefabs[animalIndex],
						new Vector3(0, 0, 20),
						animalPrefabs[animalIndex].transform.rotation);
		}
	}
}
