using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool touchingHazard;
    public UnityEvent onEnterHazard; 
    public UnityEvent<float> onRandomNumber;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //is the player inside the hazard sprite?
        if (hazard.bounds.Contains(transform.position))
        {
            if (touchingHazard)
            {
                //were still in the hazard
            }
            else
            {
                //Y: player has tripped the sensor
                touchingHazard = true;
                onEnterHazard.Invoke();
            }
        }
        else
        {
            if (touchingHazard)
            {
                //we've just left the hazard
                //N: player has not tripped the sensor
                touchingHazard = false;
                onRandomNumber.Invoke(Random.Range(1, 100000000));
            }
            else
            {
                //we're still not in the hazard
            }
            
        }
    }

    public void showNumber(float number)
    {
        Debug.Log(number);
    }
}
