using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_with_arrow : MonoBehaviour
{

    public delegate void ArrowDestroyedHandler();
    public static event ArrowDestroyedHandler OnArrowDestroyed;
    //private AudioSource audioSource;
    
    
    
    //void Start() {
        //audioSource = GetComponent<AudioSource>();

    //}


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Arrow")){
            OnArrowDestroyed?.Invoke();
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Arrow"))
        {
            OnArrowDestroyed?.Invoke();
            Destroy(other.gameObject);
        }
    }

}
