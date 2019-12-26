using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonfly : MonoBehaviour {

    public AudioClip shotSound;
    public float W = -200;
    public float H = 200;

    void Awake()
    {
        AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position, 1f);
    }

	void Update () {
        transform.position += new Vector3(W, H, 0) * Time.deltaTime;
        Destroy(gameObject, 1.5f);		
	}
}
