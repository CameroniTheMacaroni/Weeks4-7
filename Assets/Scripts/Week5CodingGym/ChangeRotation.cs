using UnityEngine;
using UnityEngine.UI;

public class ChangeRotation : MonoBehaviour
{
    Vector3 rot;
    public Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    
    void Update()
    {

        rot.z = slider.value;
        transform.eulerAngles = rot;

    }
}
