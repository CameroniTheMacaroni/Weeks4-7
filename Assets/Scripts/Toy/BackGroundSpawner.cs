using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BackGroundSpawner : MonoBehaviour
{
    public Vector2 startPos;//where the planet/stars will start
    public float timerPlanet;//controls the how long the spawner will take in-between spawns
    public float maxTimerPlanet = 1.5f;

    public float timerStar;//controls the how long the spawner will take in-between spawns
    public float maxTimerStar = 1.5f;

    public float speed;//slider value
    float starSpeed = 30f;//value added to the speed of the stars but not the planets
    //prefabs
    public GameObject planet;
    public GameObject star;

    public GameObject spawnedthing;
    public MoveToTheLeftScript movescript;//script of the prefab that makes it move

    public Slider slider;
    public TextMeshProUGUI distanceValueText;
    public TextMeshProUGUI distanceText;
    public float distance;
    void Start()
    {

    }

    void Update()
    {
        speed = slider.value;

        distance += speed;
        distanceText.text = "Distance travelled (km): ";
        distanceValueText.text = distance.ToString();//set the text in the top right to be equal to the distance travelled

        timerPlanet += Time.deltaTime;
        timerStar += Time.deltaTime;

        if (timerPlanet >= maxTimerPlanet)//begin once a certain amount of time has passed
        {
            timerPlanet = 0;
            //Move to random location offscreen
            startPos = new Vector2(12, Random.Range(6.0f, -6.0f));
            transform.position = startPos;
            //spawn planet
            spawnedthing = Instantiate(planet, transform.position, transform.rotation);

            movescript = spawnedthing.GetComponent<MoveToTheLeftScript>();//find the script with the speed on the prefab
            movescript.speed = speed;//change the speed to match the slider
        }

        if (timerStar >= maxTimerStar)
        {
            timerStar = 0;
            //Move to random location offscreen
            startPos = new Vector2(12, Random.Range(6.0f, -6.0f));
            transform.position = startPos;
            //spawn planet
            spawnedthing = Instantiate(star, transform.position, transform.rotation);
            movescript = spawnedthing.GetComponent<MoveToTheLeftScript>();//find the script with the speed on the prefab
            movescript.speed = speed + starSpeed;//change the speed to match the slider 
        }
    }
}
