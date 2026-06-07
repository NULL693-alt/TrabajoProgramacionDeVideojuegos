using UnityEngine;

public class Moverse : MonoBehaviour
{

    private int vidas = 1;

    private float velocidad = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void movimineto()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, v) * velocidad * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
      movimineto();   
    }
}
