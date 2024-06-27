using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Rigidbody ballRigidbody;
    public Transform target;
    public float forceMagnitude = 10f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ApplyForceToBall();
        }
    }

    void ApplyForceToBall()
    {
        if (ballRigidbody == null || target == null)
        {
            Debug.LogError("Ball Rigidbody or Target Transform is not assigned.");
            return;
        }

        // Calculate the direction from the ball to the target
        Vector3 direction = (target.position - ballRigidbody.position).normalized;

        // Apply the force to the ball
        ballRigidbody.AddForce(direction * forceMagnitude, ForceMode.Impulse);
    }
}
