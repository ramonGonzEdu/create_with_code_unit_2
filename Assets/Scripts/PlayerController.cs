using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	public float speed = 20.0f;
	public float xrange = 10;
	public GameObject projectilePrefab;

	private void Start()
	{

	}

	private void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
		if (transform.position.x < -xrange)
		{
			transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
		}
		if (transform.position.x > xrange)
		{
			transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
		}

		if (Input.GetKeyDown(KeyCode.Space) || (Application.isEditor && Input.GetKeyDown(KeyCode.O)))
		{
			//TODO: Launch a projectile from the player
			Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
		}
	}
}