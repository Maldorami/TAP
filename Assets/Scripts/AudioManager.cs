using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public static AudioManager instance;

    public AudioSource audio;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

	void Start () {
        if (!instance)
        {
            instance = this;
            if(!audio.isPlaying) audio.Play();
        }
        else
        {
            Destroy(gameObject);
        }
	}
}
