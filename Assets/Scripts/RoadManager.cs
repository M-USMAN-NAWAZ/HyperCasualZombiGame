using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    public GameObject roadPrefab;
    public GameObject startpoint;

    public bool canSpawn = false;

    public float wait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoad());
    }

    public IEnumerator SpawnRoad()
    {
        canSpawn = true;
        while (canSpawn)
        {
            GameObject _road = Instantiate(roadPrefab, startpoint.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(wait);
        }
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
