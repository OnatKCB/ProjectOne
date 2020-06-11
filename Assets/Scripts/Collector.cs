using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Danger_Object") 
        {
            other.gameObject.transform.parent = transform;
            other.gameObject.SetActive(false);
        }
    }
}
