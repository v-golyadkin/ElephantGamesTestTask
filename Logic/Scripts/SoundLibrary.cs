using System;
using UnityEngine;

[Serializable]
public struct Sound
{
    public string name;
    public AudioClip clip;
    public float volume;
}

public class SoundLibrary : MonoBehaviour
{
    [SerializeField] private Sound[] _sounds;

    public AudioClip GetClipFromName(string name)
    {
        foreach(var sound in _sounds)
        {
            if(sound.name == name)
            {
                return sound.clip;
            }
        }

        return null;
    }

    public float GetVolume(string name)
    {
        foreach(var sound in _sounds)
        {
            if(sound.name == name)
            {
                return sound.volume;
            }
        }

        return 0f;
    }
}
