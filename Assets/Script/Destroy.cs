using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject platformPrefab;
    public GameObject springPrefab;
    public GameObject catPrefab;
    private GameObject myPlat;
    public GameObject birdPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (Random.Range(1, 30) > 1)
        {
            myPlat = (GameObject)Instantiate(platformPrefab, new Vector2(Random.Range(-2.3f, 2.2f), player.transform.position.y + (2 + Random.Range(0.5f,0.7f))), Quaternion.identity);
        }
        else
        {
            myPlat = (GameObject)Instantiate(springPrefab, new Vector2(Random.Range(-2.5f, 2.2f), player.transform.position.y + (2 + Random.Range(0.5f, 20f))), Quaternion.identity);
            myPlat = (GameObject)Instantiate(catPrefab, new Vector2(Random.Range(-2.5f, 2.2f), player.transform.position.y + (2 + Random.Range(0.5f, 75f))), Quaternion.identity);
            myPlat = (GameObject)Instantiate(birdPrefab, new Vector2(Random.Range(-2.5f, 2.2f), player.transform.position.y + (2 + Random.Range(0.5f, 25f))), Quaternion.identity);
        }

        Destroy(collision.gameObject);


    }


}
