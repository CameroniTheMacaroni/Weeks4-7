using System.Collections.Generic;
using UnityEngine;

public class KnifeSpawnerLogic : MonoBehaviour
{
    public Vector3 rot;
    public Vector2 currentPos;

    public List<GameObject> knives;
    public GameObject knife;
    public int knivesAmount = 5;

    public PirateGoOut pirateGoOut;

    void Start()
    {
        rot = new Vector3(0, 0, 210);
        currentPos = new Vector2(-3, 3);

        for (int i = 0; i < knivesAmount; i++)
        {
            rot += new Vector3(0, 0, -10);//rotate each knife by 10 degrees clockwise of the last
            transform.eulerAngles = rot;

            currentPos += new Vector2(1, 0);//move each knife by one unit to the right of the last
            transform.position = currentPos;

            GameObject spawnedKnife = Instantiate(knife, transform.position, transform.rotation);//spawn knives

            knives.Add(spawnedKnife);
            PirateGoOut abc = spawnedKnife.GetComponent<PirateGoOut>();

        }
    }


    void Update()
    {

    }
}
