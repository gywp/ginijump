using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cat : MonoBehaviour
{
    public player1 player;
    public AudioClip bSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            player.GameOver();
            GetComponent<AudioSource>().clip = bSound;
            GetComponent<AudioSource>().Play();
        }
    }
        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
