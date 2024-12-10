using UnityEngine;

// Makes a transform oscillate left and right relative to its start position
public class Oscillator : MonoBehaviour
{
    [SerializeField, Tooltip("Distance to oscillate (in meters)")]
    private float m_Amplitude = 10.0f; // Increase this value to extend the oscillation range

    [SerializeField, Tooltip("Time to complete one oscillation (in seconds)")]
    private float m_Period = 2.0f; // Time it takes for one full left-right oscillation

    private Vector3 m_StartPosition;

    void Start(){
        // Record the starting position of the object
        m_StartPosition = transform.position;
    }

    void Update(){
        // Time-based oscillation
        float time = Time.time / m_Period; // Normalize time based on the period
        float offset = Mathf.Cos(2.0f * Mathf.PI * time); // Smooth oscillation between -1 and 1

        // Apply the movement along the X-axis (left and right)
        Vector3 pos = m_StartPosition + Vector3.right * m_Amplitude * offset;

        // Update the transform position
        transform.position = pos;
    }  
}
