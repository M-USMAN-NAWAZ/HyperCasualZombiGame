using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    void Start()
    {
        direction = transform.forward;
    }


    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
