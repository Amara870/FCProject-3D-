using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SaveAudio : MonoBehaviour
{
    public AudioMixer audioMixer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Save()
    {
        float mainVolume;
        audioMixer.GetFloat("MainAudio", out mainVolume);
        PlayerPrefs.SetFloat("mainAudio", mainVolume);
        float musicVolume;
        audioMixer.GetFloat("MusicAudio", out musicVolume);
        PlayerPrefs.SetFloat("musicAudio", musicVolume);
        float sfxVolume;
        audioMixer.GetFloat("SFXAudio", out sfxVolume);
        PlayerPrefs.SetFloat("sFXAudio", sfxVolume);
        float enemiesVolume;
        audioMixer.GetFloat("EnemiesAudio", out enemiesVolume);
        PlayerPrefs.SetFloat("enemiesAudio", enemiesVolume);
        PlayerPrefs.Save();
    }
}
