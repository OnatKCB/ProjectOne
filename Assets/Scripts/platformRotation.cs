using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformRotation : MonoBehaviour
{
    public GameObject Platform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Platform.transform.Rotate(10 * Time.deltaTime * 2, 10 * Time.deltaTime * 2, 10 * Time.deltaTime * 2);
    }
}
