using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public float speed;
    private Vector3 direction;

    void Start()
    {
        direction = -transform.forward;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RoadDestroy"))
        {
            Debug.Log("Road detected this" + other.tag);
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
