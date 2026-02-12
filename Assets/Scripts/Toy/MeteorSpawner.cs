using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab;
    public GameObject meteorSpawned;

    Vector2 startPos;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void spawnMeteor()
    {
        for (int i = 0; i < 10; i++)
        {
            startPos = new Vector2(Random.Range(2, 15), Random.Range(5, 15));
            transform.position = startPos;
            meteorSpawned = Instantiate(meteorPrefab, transform.position, transform.rotation);
        }
    }
}
