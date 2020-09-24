using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COLLECTCOIN : MonoBehaviour
{
    public AudioSource collectSound;
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        SCORINGSYSYSTEM.theScore += 5;
        Destroy(gameObject);
    }
}
