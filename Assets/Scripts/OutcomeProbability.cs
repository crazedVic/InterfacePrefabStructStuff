using UnityEngine;

[System.Serializable]
public struct OutcomeProbability
{
    public MonoBehaviour outcomeComponent;
    public float probability;

    public IOutcome Outcome => outcomeComponent as IOutcome;
}