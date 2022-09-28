using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Wp_Actor : MonoBehaviour
{





    float speed = 5.0F;
    public Transform target;
   
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0,speed * Time.deltaTime));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "wpPoint") {

            target = other.gameObject.GetComponent<wpPoint>().nexPoint;
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }
}
