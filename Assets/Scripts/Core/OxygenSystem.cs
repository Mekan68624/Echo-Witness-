using UnityEngine;

public class OxygenSystem : MonoBehaviour
{
    [Header("Настройки кислорода")]
    public float maxOxygen = 100f;
    public float currentOxygen = 100f;
    public float drainPerSecond = 0.15f;

    private bool isPaused = false;

    void Update()
    {
        if (isPaused || currentOxygen <= 0f)
            return;

        currentOxygen -= drainPerSecond * Time.deltaTime;
        currentOxygen = Mathf.Clamp(currentOxygen, 0f, maxOxygen);

        if (currentOxygen <= 0f)
        {
            Debug.Log("Кислород закончился!");
        }
    }

    public void AddOxygen(float amount)
    {
        currentOxygen = Mathf.Clamp(
            currentOxygen + amount, 0f, maxOxygen);
    }

    public void SetPaused(bool paused)
    {
        isPaused = paused;
    }
}