using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATCOIN : MonoBehaviour
{
    public int rotateSpeed;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,  0, rotateSpeed, Space.World);
    }
}
