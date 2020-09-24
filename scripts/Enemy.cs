using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Unity Setup")]
    public ParticleSystem exparticles;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("obstacle")) { 
            Destroy();
        }
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
