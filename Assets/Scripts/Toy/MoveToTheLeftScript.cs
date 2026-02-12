using UnityEngine;
using UnityEngine.UI;

public class MoveToTheLeftScript : MonoBehaviour
{
    public float speed = 1f;//how fast the planet/stars will move
    public Vector2 pos;//where the planet/stars will start

    public bool isStar;
    //public Slider speedSlider;
    void Start()
    {
        if(speed >= 30)//if the spawned object is going fast enough
        {
            isStar = true;
        }
        else
        {
            isStar = false;
        }
        
    }

    void Update()
    {
        //speed = speedSlider.value;
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);//move self by speed value

        if (isStar)
        {
            transform.localScale = new Vector3(speed / 15, transform.localScale.y, transform.localScale.z);//stretch the image based on the speed (mostly for stars)
        }
    }
}
