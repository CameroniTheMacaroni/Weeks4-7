using UnityEngine;

public class RandomRotate : MonoBehaviour
{
    public float rotSpeed;
    Vector3 rot;
    void Start()
    {
        rotSpeed = Random.Range(-500, 500);
    }

    
    void Update()
    {
        rot = transform.eulerAngles;
        rot.z += rotSpeed*Time.deltaTime;
        transform.eulerAngles = rot;
    }
}
