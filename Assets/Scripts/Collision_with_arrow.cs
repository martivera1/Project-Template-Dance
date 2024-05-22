using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_with_arrow : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Arrow")){
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Arrow"))
        {
            Destroy(other.gameObject);
        }
    }

}
