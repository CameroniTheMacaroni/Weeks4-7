using UnityEngine;

public class SpinScript : MonoBehaviour
{
    public float speed = -200;
    Vector3 rot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rot = transform.eulerAngles;
        rot.z += speed * Time.deltaTime;
        transform.eulerAngles = rot;
    }

    public void beginRotation()
    {
        speed = -300;
    }
    public void endRotation()
    {
        speed = 0;
    }
}
