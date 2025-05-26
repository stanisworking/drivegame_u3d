using System;
using System.Collections;
using UnityEngine;

[Serializable]
public class ActivationRule
{
    public GameObject objectToActivate;
    public float activateDelay;
}

public class GameManager : MonoBehaviour
{
    public ActivationRule[] rules;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (ActivationRule rule in rules)
        {
            StartCoroutine(Activate(rule));
        }
    }

    private IEnumerator Activate(ActivationRule rule)
    {
        yield return new WaitForSeconds(rule.activateDelay);
        rule.objectToActivate.SetActive(true);
    }
}
