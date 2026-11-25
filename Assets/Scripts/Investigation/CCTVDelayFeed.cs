using UnityEngine;

public class CCTVDelayFeed : MonoBehaviour
{
    public Camera securityCamera;
    public RenderTexture delayedScreen;

    public float delaySeconds = 15f;

    private RenderTexture[] frames;
    private float[] times;
    private int index;

    void Start()
    {
        frames = new RenderTexture[300];
        times = new float[300];

        for (int i = 0; i < frames.Length; i++)
        {
            frames[i] = new RenderTexture(256, 144, 16);
        }
    }

    void Update()
    {
        if (securityCamera == null) return;

        if (Time.time - times[index] >= 0.05f)
        {
            securityCamera.targetTexture = frames[index];
            securityCamera.Render();

            times[index] = Time.time;
            index = (index + 1) % frames.Length;
        }

        int delayedIndex = index;
        float targetTime = Time.time - delaySeconds;

        for (int i = 0; i < times.Length; i++)
        {
            if (times[i] <= targetTime)
                delayedIndex = i;
        }

        if (delayedScreen != null)
        {
            Graphics.Blit(frames[delayedIndex], delayedScreen);
        }
    }

    void OnDestroy()
    {
        if (frames == null) return;

        foreach (var frame in frames)
        {
            if (frame != null)
                frame.Release();
        }
    }
}