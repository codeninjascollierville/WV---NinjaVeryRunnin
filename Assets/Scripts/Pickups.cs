using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public ParticleSystem Pickup;
    public GameObject Door;
    void Start()
    {
       Pickup.Stop();
    }

    void Update()
    {
    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);

            Pickup.Play();
            Destroy(Door);

        }
    }
    
}
