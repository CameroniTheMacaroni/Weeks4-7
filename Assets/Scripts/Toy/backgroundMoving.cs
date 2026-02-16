using UnityEngine;

public class backgroundMoving : MonoBehaviour
{
    public Vector2 pos = new Vector2(16, 0);
    public float speed = 3;
    public float resetAt = -14f;
    void Start()
    {
        
    }

    
    void Update()
    {
        pos += new Vector2(-Time.deltaTime*speed, 0);
        transform.position = pos;

        if(pos.x <= resetAt)
        {
            pos.x = 16; 
        }
    }
}
