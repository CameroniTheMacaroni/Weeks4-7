using UnityEngine;

public class RandomizePositionScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3((Random.value*20) - 10, (Random.value*10) - 5, 0);
    }
}
