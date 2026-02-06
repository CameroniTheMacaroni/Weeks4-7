using UnityEngine;

public class MoveToTheLeftScript : MonoBehaviour
{
    public float speed = 0.1f;//how fast the planet/stars will move
    public Vector2 pos;//where the planet/stars will start
    void Start()
    {
        //pos = new Vector2(12, Random.Range(6.0f, -6.0f));//spawn offscreen to the right, with a random y value
        //transform.position = pos;
    }

    void Update()
    {
        //pos.x -= speed;
        transform.position = new Vector2(transform.position.x - speed, transform.position.y);

    }
}
