using UnityEngine;

public interface IOutcome
{
    Vector3 TargetRotation { get; set; }
    GameObject Bullseye { get; set; }
    void Execute();
}
