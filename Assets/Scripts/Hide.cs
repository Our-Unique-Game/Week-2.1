using UnityEngine;

// Toggles the visibility of the object in the scene given an input key
public class Hide : MonoBehaviour
{
    [Tooltip("The key to press to toggle visibility")]
    public KeyCode m_HideKey = KeyCode.H; // The key to press to toggle visibility

    private Renderer m_Renderer;

    void Start(){
        // Get the Renderer component of the object
        m_Renderer = GetComponent<Renderer>();
    }

    void Update(){
        // Toggles visibility when the key is pressed
        if (Input.GetKeyDown(m_HideKey))
        {
            m_Renderer.enabled = !m_Renderer.enabled; // Toggle the renderer's enabled state
        }
    }
}
