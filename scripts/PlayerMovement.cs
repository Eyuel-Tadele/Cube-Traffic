using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidway = 5f;
    private Touch touch; 
    private float speedModifier;


    // Start is called before the first frame update
    void Start()
    {
        speedModifier = sidway;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.position.y < -1f)
        {
            FindObjectOfType<MG>().EndGame();
        }
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(
                    transform.position.x + touch.deltaPosition.x * speedModifier,
                    transform.position.y,
                    transform.position.z + touch.deltaPosition.y * speedModifier);
            }
        }
    }
   
}
