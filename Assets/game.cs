using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public player1 player;
    public TextMesh highscore;
    public TextMesh endscore;
    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("BestScore").ToString("N0");
        endscore.text = player.topScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
