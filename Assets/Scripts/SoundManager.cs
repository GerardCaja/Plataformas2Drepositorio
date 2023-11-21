using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {get; private set;}
    
    AudioSource _sfxAudioSource;
    [SerializeField] private AudioClip deathZone;
    [SerializeField] private AudioClip bomb;
    [SerializeField] private AudioClip star;
    [SerializeField] private AudioClip music;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }

        _sfxAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void GameOver()
    {
        Debug.Log("GameOver");
    }

    public void DeathZone()
    {
        _sfxAudioSource.PlayOneShot(deathZone);
    }

    public void Bomb()
    {
        _sfxAudioSource.PlayOneShot(bomb);
    }

    public void Star()
    {
        _sfxAudioSource.PlayOneShot(star);
    }

    public void Music()
    {
        _sfxAudioSource.PlayOneShot(music);
    }
}
