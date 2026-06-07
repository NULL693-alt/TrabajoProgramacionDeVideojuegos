using UnityEngine;

public class Moverse : MonoBehaviour
{

    [SerializeField]private float speed;

    private Rigidbody rb; 
    private float xImput;

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
        
    }
}
