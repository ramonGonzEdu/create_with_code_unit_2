using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;
	public float speed = 10.0f;
	public float xrange = 10;

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
	}
}