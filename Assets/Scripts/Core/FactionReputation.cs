using UnityEngine;
using System.Collections.Generic;

public class FactionReputation : MonoBehaviour
{
    public Dictionary<string, int> reputation =
        new Dictionary<string, int>();

    void Start()
    {
        reputation["Полиция"] = 50;
        reputation["Подполье"] = 50;
        reputation["Жители"] = 50;
    }

    public void ChangeReputation(string faction, int amount)
    {
        if (!reputation.ContainsKey(faction))
            reputation[faction] = 50;

        reputation[faction] = Mathf.Clamp(
            reputation[faction] + amount, 0, 100);

        Debug.Log(faction + ": " + reputation[faction]);
    }

    public int GetReputation(string faction)
    {
        return reputation.ContainsKey(faction)
            ? reputation[faction] : 0;
    }
}