using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SCORINGSYSYSTEM : MonoBehaviour
{
    public GameObject COINSCORE;
    public static int theScore;
   
    private void Update()
    {
        
        COINSCORE.GetComponent<Text>().text = "COIN: " + theScore;
    }


}
