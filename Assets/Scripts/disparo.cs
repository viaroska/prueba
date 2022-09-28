using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class disparo : MonoBehaviour
{
   

    public Transform spawnPoint;

    public GameObject bullet;

/// <summary>
//////////////////////////////////////////////////////77
/// </summary>
   
///////////////////////////////////////////777


  // int contador;
    public float shotForce = 1500f;
    public float shotRate = 0.5f;
    private float shotRateTime = 0;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRateTime)
            {
                GameObject newBullet;

                newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);

                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
                
                shotRateTime = Time.time + shotRate;
                
                Destroy(newBullet, 2);
               

            }
        }
    }
    /// <summary>
    /// //////////////////////////////////////////////77
    /// </summary>
   
}
