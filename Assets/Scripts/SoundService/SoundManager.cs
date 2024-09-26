
using System;
using UnityEngine;

public class SoundManager
{
    private AudioSource audioSource;
    private SoundType[] soundTypes;

    public SoundManager(AudioSource audioSource, SoundType[] soundTypes)
    {
        this.audioSource = audioSource;
        this.soundTypes = soundTypes;
    }

    public void PlaySound(Sound sound)
    {
        AudioClip clip = GetAudioClip(sound);
        if (clip!=null)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    private AudioClip GetAudioClip(Sound sound)
    {
        SoundType i=Array.Find(soundTypes,i=>i.sound==sound);
        if (i != null)
        {
            return i.clip;
        }
        return null;
    }
}

[Serializable]
public class SoundType
{
    public Sound sound;
    public AudioClip clip;
}

