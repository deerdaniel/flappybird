using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using _Project.Scripts.Singleton;

public class AudioManager : MonoSingleton<AudioManager>
{
  [Header("Audio Sources")]
  [SerializeField][Tooltip("Main GameAudio")] private AudioSource _mainSource;
  [SerializeField][Tooltip("SFX effects audio")] private AudioSource _sfxSource;

  [Header("Audio Clips")] 
  [SerializeField] private AudioClip[] _mainClips;
  [SerializeField] private AudioClip[] _sfxClips;

  private void Awake()
  {
    if (_mainSource || _sfxSource)
    {
      Debug.LogError("One with audio sources is empty !!!");
    }
  }

  private void SetClipInAudioSource(AudioSource source, int clipID, AudioClip[] clips)
  {
    source.clip = clips[clipID];
  }

  #region Main Audio

  public void PlayMainClip(int id)
  {
    SetClipInAudioSource(_mainSource,id,_mainClips);
    _mainSource.Play();
  }
  
  public void StopMainClip()
  {
    _mainSource.Stop();
  }

  #endregion


  #region SFX Audio
  
  public void PlaySfxClip(int id)
  {
    SetClipInAudioSource(_sfxSource,id,_sfxClips);
    _mainSource.Play();
  }
  
  public void StopSfxClip()
  {
    _mainSource.Stop();
  }

  #endregion
}
