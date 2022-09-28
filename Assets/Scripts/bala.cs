using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bala : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            
            Destroy(collision.gameObject);
          
            ///     contador = contador + 1;
        }
    }

   //
}
