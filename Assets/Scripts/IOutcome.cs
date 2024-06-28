using UnityEngine;

public interface IOutcome
{
    // only way to define properties is using get/set
    // however this means these are not exposable in property inspector
    // so you would have to implement them like this AND then expose the underlying property 
    // as public or [SerializeField] private
    Vector3 TargetRotation { get; set; }
    GameObject Bullseye { get; set; }
    float TimeToLive { get; set; }
    void Execute();
}
