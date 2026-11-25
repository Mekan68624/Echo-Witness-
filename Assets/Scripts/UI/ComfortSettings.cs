using UnityEngine;

public class ComfortSettings : MonoBehaviour
{
    public bool disableJumpScares = false;
    public bool reduceFlashing = true;
    public float masterVolume = 0.7f;

    void Start()
    {
        LoadSettings();
        ApplySettings();
    }

    public void ApplySettings()
    {
        AudioListener.volume = masterVolume;
        PlayerPrefs.SetInt("JumpScares",
            disableJumpScares ? 1 : 0);
        PlayerPrefs.SetInt("ReduceFlashing",
            reduceFlashing ? 1 : 0);
        PlayerPrefs.SetFloat("Volume", masterVolume);
        PlayerPrefs.Save();
    }

    public void LoadSettings()
    {
        disableJumpScares =
            PlayerPrefs.GetInt("JumpScares", 0) == 1;

        reduceFlashing =
            PlayerPrefs.GetInt("ReduceFlashing", 1) == 1;

        masterVolume =
            PlayerPrefs.GetFloat("Volume", 0.7f);
    }
}