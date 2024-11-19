using UnityEngine;

// A simple script that makes the object grow bigger and smaller, like a heartbeat
public class Heartbeat : MonoBehaviour
{
    [SerializeField, Tooltip("The maximum scale of the object")]
    private float m_MaxScale = 1.0f; // The maximum scale of the object

    [SerializeField, Tooltip("The minimum scale of the object")]
    private float m_MinScale = 0.5f; // The minimum scale of the object

    [SerializeField, Tooltip("Time to complete one heartbeat (in seconds)")]
    private float m_Period = 1.5f; // Time it takes for one full heartbeat

    void Start()
    {   
    }

    // Update is called once per frame
    void Update()
    {
        // Time-based heartbeat
        float time = Time.time / m_Period; // Normalize time based on the period
        float offset = Mathf.Cos(2.0f * Mathf.PI * time); // Smooth oscillation between -1 and 1

        // Calculate the scale based on the offset
        float scale = Mathf.Lerp(m_MinScale, m_MaxScale, (offset + 1.0f) / 2.0f);

        // Apply the scale to the object
        transform.localScale = new Vector3(scale, scale, scale);
    }
}
