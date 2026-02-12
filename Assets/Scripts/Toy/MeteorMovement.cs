using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    Vector3 movement = new Vector3 (-1, -1, 0);
    public float speed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += movement * speed * Time.deltaTime;
    }
}
