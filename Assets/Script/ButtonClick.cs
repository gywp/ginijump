using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Time.timeScale = (isPaused) ? 1.0f : 1.0f;
        if (CompareTag("GameStart")) SceneManager.LoadScene("Start"); 
        if (CompareTag("Ranking")) SceneManager.LoadScene("Ranking");
        if (CompareTag("MainLayout")) SceneManager.LoadScene("MainLayout");
        if (CompareTag("Option")) SceneManager.LoadScene("Option");
        if (CompareTag("Quit")) Application.Quit();
        if (CompareTag("USA")) SceneManager.LoadScene("USA");
        if (CompareTag("Korea")) SceneManager.LoadScene("Korea");
        if (CompareTag("Egypt")) SceneManager.LoadScene("Egypt");
        if (CompareTag("France")) SceneManager.LoadScene("France");
        if (CompareTag("PauseButton"))
        {
            //일시정지 구현 학교에서 배운대로
        }
    }

    public void BtnClick()
    {
        Time.timeScale = (isPaused) ? 1.0f : 1.0f;
        if (CompareTag("USA")) SceneManager.LoadScene("USA");
        if (CompareTag("Korea")) SceneManager.LoadScene("Korea");
        if (CompareTag("Egypt")) SceneManager.LoadScene("Egypt");
        if (CompareTag("France")) SceneManager.LoadScene("France");
        
    }
}
