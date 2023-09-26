using UnityEngine;

public class ArrowIndicator : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform component
    public float oscillationDistance = 0.2f; // Adjust the distance of oscillation
    public float oscillationSpeed = 2.0f; // Adjust the speed of oscillation

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position of the arrow
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Add oscillation to the arrow's position at the starting point
        Vector3 oscillationOffset = Vector3.right * Mathf.Sin(Time.time * oscillationSpeed) * oscillationDistance;

        // Set the arrow's position to the initial position plus the oscillation offset
        transform.position = initialPosition + oscillationOffset;
    }
}
