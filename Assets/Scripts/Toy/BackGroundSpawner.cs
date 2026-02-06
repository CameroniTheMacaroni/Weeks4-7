using UnityEngine;
using static UnityEditor.PlayerSettings;

public class BackGroundSpawner : MonoBehaviour
{
    public Vector2 startPos;//where the planet/stars will start
    public float timerPlanet;//controls the how long the spawner will take in-between spawns
    public float maxTimerPlanet = 1.5f;

    public GameObject planet;
    void Start()
    {
        
    }

    void Update()
    {
        

        timerPlanet += Time.deltaTime;

        if (timerPlanet >= maxTimerPlanet)
        {
            timerPlanet = 0;
            //Move to random location offscreen
            startPos = new Vector2(12, Random.Range(6.0f, -6.0f));
            transform.position = startPos;
            //spawn planet
            Instantiate(planet, transform.position, transform.rotation);
        }
    }
}
