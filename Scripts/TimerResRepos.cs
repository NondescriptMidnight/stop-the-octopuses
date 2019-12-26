using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerResRepos : MonoBehaviour {

    public GameObject timer;
    public AudioClip letterSound;
    public float width = 0;
    public float height = 0;

    void Start()
    {
        AudioSource.PlayClipAtPoint(letterSound, Camera.main.transform.position, 1f);
    }
}
