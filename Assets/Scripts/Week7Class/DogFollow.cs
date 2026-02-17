using UnityEngine;

public class DogFollow : MonoBehaviour
{
    public bool bonded = false;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bonded)
        {
            //transform.position = player.transform.position + new Vector3(-1, -1, 0);
        }
    }

    public void playerMeetsDog()
    {
        //bonded = true;
        transform.position = player.transform.position + new Vector3(-1, -1, 0);
        transform.parent = player.transform;
        //transform.position = Vector3.zero;

    }
}
