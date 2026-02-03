using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnerScript : MonoBehaviour
{
    public GameObject piratething;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            Instantiate(piratething, transform.position, transform.rotation);
           // piratething.transform.position = new Vector3(1, 1, 0);
        }
    }
}
