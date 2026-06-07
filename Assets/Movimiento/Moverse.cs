using UnityEngine;

public class Moverse : MonoBehaviour
{

    [SerializeField]private float speed;
    [SerializeField]private float jumpForce = 5f;

    private Rigidbody rb; 
    private float xImput;
    private float zImput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        xImput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(xImput * speed, rb.linearVelocity.y);
        rb.linearVelocity = movement;

        zImput = Input.GetAxis("Vertical");
        Vector3 movement2 = new Vector3(rb.linearVelocity.x, rb.linearVelocity.y, zImput * speed);
        rb.linearVelocity = movement2;
        
    }
}