using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject myPrefab;
    public Vector3 spawnPosition = new Vector3(75.0f, 0.0f, 25.0f);
    public Vector3 spawnRotation = new Vector3(100, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        Quaternion rotation = Quaternion.Euler(spawnRotation);


        Instantiate(myPrefab, spawnPosition, rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
