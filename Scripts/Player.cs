using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public AudioClip endBuzzer;

    [SerializeField]
    public Stat health;
    public static bool isOver = false;
    public static bool isStarted = false;
    public GameObject timerObject;
    public GameObject explosion;

    private bool hasPlayed = false;
	// Use this for initialization
	private void Awake() {
        isStarted = false;
        isOver = false;
        health.Initialize();
	}
	
	// Update is called once per frame
	public void Update () {

        GameObject canvas = GameObject.Find("Canvas");
        if (Input.anyKey)
        {
            isStarted = true;
        }

        if (isStarted)
        {
            health.CurrentVal -= 1 * Time.deltaTime;
        }
        if (health.CurrentVal == 0 &&  !isOver)
        {
            Invoke("GameOver", 1.5f);
            if (!hasPlayed)
            {
                GameObject explode = (GameObject)Instantiate(explosion, timerObject.transform.position, Quaternion.identity);
                explode.transform.parent = canvas.transform;
                Destroy(explode, 0.5f);
                Destroy(timerObject);
                AudioSource.PlayClipAtPoint(endBuzzer, Camera.main.transform.position, 1f);
                hasPlayed = true;
            }
        }
    }
    void GameOver()
    {
        Application.LoadLevel(1);
    }
}
