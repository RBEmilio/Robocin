using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public static SoundController instance;
   
    private AudioSource AudioSource;

    private void Awake()
    {
        if( instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        AudioSource = GetComponent<AudioSource>();
    }

    public void StartSound(AudioClip sound, float volume = 1.0f)
    {
        AudioSource.PlayOneShot(sound, volume);
    }
}
