using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 initialPos = Vector3.zero;
    public float speed = 10f;
    private float horizontalInput;
    private float xRange = 20;

    public GameObject proyectilePrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPos;
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento del jugador
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Proyectil

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilePrefab, transform.position, proyectilePrefab.transform.rotation);
        }
        
        
        
    }
}
