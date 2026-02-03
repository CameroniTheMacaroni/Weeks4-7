using UnityEngine;

public class MoveScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += transform.up * Time.deltaTime;
    }
}
