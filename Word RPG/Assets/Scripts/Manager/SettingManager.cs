using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingManager : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;
    
    public void InitManager()
    {
        Debug.Log("--- Init Manager: Setting Manager ---");
    }

    public void SetMusicVolume(float musicVolume)
    {
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(musicVolume) * 20);
    }

    public void SetSFXVolume(float sFXVolume)
    {
        audioMixer.SetFloat("SFXVolume", Mathf.Log10(sFXVolume) * 20);
    }

    public void SetVOVolume(float vOVolume)
    {
        audioMixer.SetFloat("VOVolume", Mathf.Log10(vOVolume) * 20);
    }
}
