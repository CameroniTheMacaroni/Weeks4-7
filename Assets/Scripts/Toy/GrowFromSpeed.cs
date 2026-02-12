using UnityEngine;
using UnityEngine.UI;

public class GrowFromSpeed : MonoBehaviour
{
    public Slider slider;
    public float size;
    public float valueThatYouDivideSizeBy = 50;
    void Start()
    {
        
    }

    
    void Update()
    {
        size = slider.value/valueThatYouDivideSizeBy;
        transform.localScale = new Vector3(size, size, transform.localScale.z);
    }
}
