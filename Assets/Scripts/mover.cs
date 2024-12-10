using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Horizontal speed of the object, In meters per second")]
    float speed = 1.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
        //Debug.Log("Starting");
    }

    // Update is called once per frame
    void Update(){
        // GetComponent<Transform>().Position += new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

    }
}
