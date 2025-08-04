using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject onCollectEffect;
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { 
        // Destroy the collectible
        Destroy(gameObject);
        // instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
