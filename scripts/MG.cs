using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG : MonoBehaviour
{
    
    bool gameHasEnded = false;
    public GameObject ENDGAMEUI;
    public GameObject ENDGAMEU;
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            ENDGAMEUI.SetActive(true);
            ENDGAMEU.SetActive(true);

        }
    }

  


}
