using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octomove : MonoBehaviour {

    public static bool isStopped = false;
    public GameObject boom;
    public AudioClip boomSound;

    private bool hasPlayed = false;


    void Start()
    {
        isStopped = false;
    }

	void Update () {

        

        if (Player.isStarted && !isStopped)
        {
            transform.position += new Vector3(0, -0.23f, 0) * Time.deltaTime;
        }
        if (isStopped)
        {
            Invoke("Boom", 4f);
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        GameObject centerOct = GameObject.Find("Oct10");
        isStopped = true;
        GameObject explode = (GameObject)Instantiate(boom, centerOct.transform.position, Quaternion.identity);
        Destroy(explode, 0.5f);
        AudioSource.PlayClipAtPoint(boomSound, Camera.main.transform.position, 1f);
    }

    void Boom()
    {
        if (!hasPlayed)
        {
            GameObject centerOct = GameObject.Find("Oct10");
            GameObject explode = (GameObject)Instantiate(boom, centerOct.transform.position, Quaternion.identity);
            Destroy(explode, 0.5f);
            AudioSource.PlayClipAtPoint(boomSound, Camera.main.transform.position, 1f);
            hasPlayed = true;
        }
        Destroy(gameObject);

    }
}
