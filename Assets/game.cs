using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class game : MonoBehaviour
{
   
    public TextMesh highscore;
   
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("BestScore").ToString("N0");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
