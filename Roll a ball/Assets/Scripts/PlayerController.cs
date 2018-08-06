using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody rb;
    public float speed;
	void Start()
	{
        rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
        float moveHorizonal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizonal, 0, moveVertical);
        rb.AddForce(movement * speed);
	}
}
