using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RankButton : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (CompareTag("Rank_Home_Button")) SceneManager.LoadScene("MainLayout");
    }
    public void ChangeSceneBtn()
    {
       
        switch (this.gameObject.name)
        {
            case "homebutton":
                SceneManager.LoadScene(0);
                break;
           


        }
    }
}
