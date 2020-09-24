using UnityEngine;
using UnityEngine.SceneManagement;

public class LEVELCOMPLETE : MonoBehaviour
{


    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}