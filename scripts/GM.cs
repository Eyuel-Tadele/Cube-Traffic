using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{   
    
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
      

}
