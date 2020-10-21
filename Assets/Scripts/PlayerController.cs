using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	public float speed = 10.0f;

	private void Start()
	{

	}

	private void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
		if (transform.position.x < -10)
		{
			transform.position = new Vector3(-10, transform.position.y, transform.position.z);
		}
	}
}