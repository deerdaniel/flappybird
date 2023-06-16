using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : Singleton<PlaySounds>
{
    public AudioSource goldCollect;
    public AudioSource gameOverSound;
    public void PlayCollectSound()
    {
        goldCollect.Play();
    }
    public void PlayGameOverSound()
    {
        gameOverSound.Play();
    }
}
