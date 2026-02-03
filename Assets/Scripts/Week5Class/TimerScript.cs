using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public float timerValue;
    public float timerMaxValue = 10;

    public Slider timerVis;
    void Start()
    {
        timerVis.maxValue = timerMaxValue;
    }

    
    void Update()
    {
        timerValue += Time.deltaTime;

        if (timerValue > timerMaxValue)
        {
            timerValue = 0;
        }

        timerValue = timerVis.value;
    }
}
