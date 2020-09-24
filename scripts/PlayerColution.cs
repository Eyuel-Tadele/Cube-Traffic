using UnityEngine;

public class PlayerColution : MonoBehaviour
{
    public PlayerMovement movement;
    

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
            
            FindObjectOfType<MG>().EndGame();

        }
    }
}
