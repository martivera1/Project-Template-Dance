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
        new Vector3(55.26f, -1.567744f, 26.0f),
        new Vector3(65.4f, -1.567744f, 35.0f),
        new Vector3(85.0f, -1.567744f, 25.0f),
        new Vector3(85.0f, -1.567744f, 34.8f),
        new Vector3(65.0f,-1.567744f, 54.2f),
        new Vector3(74.4f, -1.567744f, 65.1f),
        new Vector3(65.6f,-1.567744f, 64.3f),
        new Vector3(65.6f,-1.567744f, 84.7f)
    };

    public Vector3[] spawnRotations = {
        new Vector3(90, 0, 0),
        //new Vector3(90, 90, 0),
        new Vector3(90, 180, 0),
        new Vector3(90, 270, 0)
    };

    private int currentSpawnIndex = 0;
    private int currentRotationIndex = 0;


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
        Vector3 spawnRotation = spawnRotations[currentRotationIndex];

        Quaternion rotation = Quaternion.Euler(spawnRotation);
        Instantiate(myPrefab, spawnPosition, rotation);

        currentSpawnIndex = (currentSpawnIndex + 1) % spawnPositions.Length;
        currentRotationIndex = (currentRotationIndex + 1) % spawnRotations.Length;


    }

    void HandleArrowDestroyed()
    {
        
        //nextSpawnPosition = new Vector3(80.0f, 0.0f, 30.0f); 

        // Spawn a new arrow
        SpawnArrow();
    }

  
}
