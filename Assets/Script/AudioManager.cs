using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    public AudioClip Background;

    private void Start()
    {
        musicSource.clip = Background;
        musicSource.loop = true;
        musicSource.Play();
    }
}
