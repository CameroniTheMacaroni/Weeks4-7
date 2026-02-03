using UnityEngine;

public class RandomColorScript : MonoBehaviour
{
    public SpriteRenderer sr;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        
    }
    public void randomColor()
    {
        sr.color = Random.ColorHSV();
    }
}
