using UnityEngine;
using System.Collections.Generic;

public class EvidenceManager : MonoBehaviour
{
    public List<string> evidence = new List<string>();

    public void AddEvidence(string evidenceName)
    {
        if (!evidence.Contains(evidenceName))
        {
            evidence.Add(evidenceName);
            Debug.Log("Найдена улика: " + evidenceName);
        }
    }

    public bool HasEvidence(string evidenceName)
    {
        return evidence.Contains(evidenceName);
    }
}