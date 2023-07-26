using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    public Slider musicVolumeSlider;
    public Slider effectVolumeSlider;
    public AudioMixer audioMixer;
    public SettingsInterface gameSettings;
    float effectVolume;
    float musicVolume;

    void Start()
    {
        LoadSettings();
    }

    void OnEnable()
    {
        gameSettings = new SettingsInterface();

        effectVolumeSlider.onValueChanged.AddListener(delegate { OnEffectVolumeChange(); });
        musicVolumeSlider.onValueChanged.AddListener(delegate { OnMusicVolumeChange(); });

        LoadSettings();
    }


    public void OnEffectVolumeChange()
    {

        effectVolume = effectVolumeSlider.value;
        effectVolume = gameSettings.effectVolume = effectVolumeSlider.value;
        audioMixer.SetFloat("musicvolume", effectVolume);
    }

    public void OnMusicVolumeChange()
    {

        musicVolume = musicVolumeSlider.value;
        musicVolume = gameSettings.musicVolume = musicVolumeSlider.value;
        audioMixer.SetFloat("musicvolume", musicVolume);
    }


    public void SaveSettings()
    {
        string jsonData = JsonUtility.ToJson(gameSettings, true);
        File.WriteAllText(Application.persistentDataPath + "/gamesettings.json", jsonData);
    }

    public void LoadSettings()
    {
        string path = Application.persistentDataPath + "/gamesettings.json";
        if (File.Exists(path))
        {
            gameSettings = JsonUtility.FromJson<SettingsInterface>(File.ReadAllText(path));
        }
        else
        {
            gameSettings.effectVolume = 0f;
            gameSettings.musicVolume = 0f;
        }
        effectVolumeSlider.value = gameSettings.effectVolume;
        musicVolumeSlider.value = gameSettings.musicVolume;

        audioMixer.SetFloat("musicvolume", gameSettings.musicVolume);
        audioMixer.SetFloat("soundvolume", gameSettings.effectVolume);
    }

}
