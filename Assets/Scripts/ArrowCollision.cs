using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object has the tag "Player"
        if (collision.gameObject.tag == "Player")
        {
            // Destroy this gameObject (the arrow) when it collides with the player
            Destroy(collision.gameObject);
        }
    }
}
