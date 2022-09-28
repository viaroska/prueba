using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerM : MonoBehaviour
{


    
    // Start is called before the first frame update
    public float speed = 1.0f;
    public float rotationspeed = 1.0f;

    private Rigidbody physics;

    void Start()
    {
        //cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        //fisicas
        physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //movimiento
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * Time.deltaTime * speed);

        //rotacion
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0, rotationY * Time.deltaTime * rotationspeed));
     
    }

  

}
