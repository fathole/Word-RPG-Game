using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameSetting
{
    [Header("Audio Setting")]
    public bool isEnableMusic;
    public bool isEnableSFX;
    public bool isEnableVO;
    public float musicVolume;
    public float sFXVolume;
    public float vOVolume;

    [Header("DisplaySetting")]
    public FullScreenMode fullScreenMode;
    public Vector2 screenResolution;
    public FontOption fontOption;

    [Header("Language Setting")]
    public DisplayLanguageOption displayLanguageOption;
    public VOLanguageOption vOLanguageOption;
}