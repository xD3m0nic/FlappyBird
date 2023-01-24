using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongBoiSpawner : MonoBehaviour
{
    public GameObject LongBoi;
    public int LongBoiPoolSize = 5;
    public float spawnRate = 3f;
    public float LongBoiMin = -1f;
    public float LongBoiMax = 3.5f;

    private GameObject[] LongBoiP;
    private int currentLongBoi = 0;

    private Vector2 objectPoolPosition = new Vector2(-15, -25);
    private float spawnXPosition = 10f;

    private float timeSinceLastSpawned;


    void Start()
    {
        timeSinceLastSpawned = 0f;
        LongBoiP = new GameObject[LongBoiPoolSize];
        for (int i = 0; i < LongBoiPoolSize; i++)
        {
            LongBoiP[i] = (GameObject)Instantiate(LongBoi, objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0f;
            float spawnYPosition = Random.Range(LongBoiMin, LongBoiMax);
            LongBoiP[currentLongBoi].transform.position = new Vector2(spawnXPosition, spawnYPosition);
            currentLongBoi++;

            if (currentLongBoi >= LongBoiPoolSize)
            {
                currentLongBoi = 0;
            }
        }
    }
}
