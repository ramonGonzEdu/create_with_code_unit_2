using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float horizontalInput;

	private void Start()
	{

	}

	private void Update()
	{
		horizontalInput = Input.GetAxis("Horizontal");
	}
}