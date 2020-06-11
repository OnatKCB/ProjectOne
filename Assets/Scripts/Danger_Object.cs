using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Danger_Object : MonoBehaviour
{
    public Rigidbody dangerBody;

    public float speed = 1f;

    public float minSpeed = 3f;
    public float maxSpeed = 7f;

    void Awake()
    {
        dangerBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 gliding = new Vector3(transform.right.x, transform.right.y, transform.right.z);
        dangerBody.MovePosition(dangerBody.position + gliding * Time.fixedDeltaTime * speed);
    }
}
