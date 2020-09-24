
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GM gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}