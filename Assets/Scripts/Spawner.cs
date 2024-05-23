using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    public Vector3 spawnPosition = new Vector3(75.0f, 0.0f, 25.0f);
    public Vector3 spawnRotation = new Vector3(100, 0, 0);
    private Vector3 nextSpawnPosition;   

    public Vector3[] spawnPositions = {
        new Vector3(75.0f, 0.0f, 25.0f),
        new Vector3(80.0f, 0.0f, 25.0f),
        new Vector3(90.0f, 0.0f, 25.0f),
        new Vector3(120.0f, 0.0f, 25.0f),
        new Vector3(150.0f, 0.0f, 25.0f)
    };

    private int currentSpawnIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        Collision_with_arrow.OnArrowDestroyed += HandleArrowDestroyed;

        // Initialize the next spawn position
        //nextSpawnPosition = spawnPosition;
        SpawnArrow();
    }


    void OnDestroy()
    {
        // Unsubscribe from the event when this object is destroyed to prevent memory leaks
        Collision_with_arrow.OnArrowDestroyed -= HandleArrowDestroyed;
    }

    void SpawnArrow()
    {
        Vector3 spawnPosition = spawnPositions[currentSpawnIndex];
    

        Quaternion rotation = Quaternion.Euler(spawnRotation);
        Instantiate(myPrefab, spawnPosition, rotation);


        currentSpawnIndex = (currentSpawnIndex + 1) % spawnPositions.Length;

    }

    void HandleArrowDestroyed()
    {
        
        //nextSpawnPosition = new Vector3(80.0f, 0.0f, 30.0f); 

        // Spawn a new arrow
        SpawnArrow();
    }

  
}
