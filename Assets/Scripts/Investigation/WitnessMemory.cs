using UnityEngine;

public class WitnessMemory : MonoBehaviour
{
    public bool remembersPlayer = false;
    public float memoryDuration = 120f;

    private float memoryTimer;

    public void NoticePlayer()
    {
        remembersPlayer = true;
        memoryTimer = memoryDuration;
        Debug.Log("Свидетель запомнил игрока!");
    }

    void Update()
    {
        if (!remembersPlayer) return;

        memoryTimer -= Time.deltaTime;

        if (memoryTimer <= 0f)
        {
            remembersPlayer = false;
            Debug.Log("Свидетель забыл игрока.");
        }
    }
}