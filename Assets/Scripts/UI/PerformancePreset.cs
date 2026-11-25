using UnityEngine;

public class PerformancePreset : MonoBehaviour
{
    public int targetFPS = 60;
    public int textureQuality = 1;

    void Start()
    {
        ApplySettings();
    }

    public void ApplySettings()
    {
        Application.targetFrameRate = targetFPS;
        QualitySettings.vSyncCount = 0;
        QualitySettings.shadows = ShadowQuality.HardOnly;
        QualitySettings.shadowResolution = ShadowResolution.Low;
        QualitySettings.shadowDistance = 25f;
        QualitySettings.antiAliasing = 2;
        QualitySettings.masterTextureLimit = textureQuality;
    }

    public void SetLowGraphics()
    {
        targetFPS = 30;
        textureQuality = 1;
        ApplySettings();
    }

    public void SetHighGraphics()
    {
        targetFPS = 60;
        textureQuality = 0;
        ApplySettings();
    }
}