using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class player1 : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float moveInput;
    private float speed = 3f;
    float horizontal;
    public Text scoreText;
    public float topScore = 0.0f;
    public GameObject gameover;
    public TextMeshPro endscoreText;
    public TextMeshPro highscoreText;
    public GameObject pause;
    private bool isPaused;
    public AudioClip catchSound;
    public AudioClip dieSound;
    private AudioSource audioSource;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        gameover.SetActive(false);
        pause.SetActive(false);
    }
    public void SoundPlay(AudioClip ac)
    {
        audioSource.clip = ac;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        pause.SetActive(false);
        if (rb2d.velocity.y > 0 && transform.position.y > topScore)
        {
            topScore = transform.position.y;
        }
        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
        if (rb2d.velocity.y < -10)
        {
            
            GameOver();
        }
    }
    void FixedUpdate()
    { 
        if (Application.platform == RuntimePlatform.Android)
          {
              horizontal = Input.acceleration.x;
          }
          if (Input.acceleration.x < 0)
          {
              gameObject.GetComponent<SpriteRenderer>().flipX = false;
          }
          if (Input.acceleration.x > 0)
          {
              gameObject.GetComponent<SpriteRenderer>().flipX = true;
          }
       rb2d.velocity = new Vector2(Input.acceleration.x * 10f, rb2d.velocity.y);
      /*  moveInput = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveInput * speed, rb2d.velocity.y);*/

    }
    public void GameOver()
    {
        
       
        gameover.SetActive(true);
        SoundPlay(dieSound);
        speed = 0;
        if (topScore > PlayerPrefs.GetFloat("BestScore"))
        {
            PlayerPrefs.SetFloat("BestScore", topScore);
        }

        endscoreText.text = topScore.ToString("N0");
        highscoreText.text = PlayerPrefs.GetFloat("BestScore").ToString("N0");

    }
    
   public void OnPauseClick()
    {
        SoundPlay(catchSound);
        pause.SetActive(true);
        isPaused = !isPaused;
        Time.timeScale = (isPaused) ? 0.0f : 1.0f;
        var playerObj = GameObject.FindGameObjectWithTag("Player");
        var scripts = playerObj.GetComponents<MonoBehaviour>();
        foreach(var script in scripts)
        {
            script.enabled = !isPaused;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("bird"))
        {
            
            GameOver();

        }
        else if(collision.tag.Equals("cat")){
            GameOver();
        }

    }
}
