using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAndPowerUpManager : MonoBehaviour
{
    public GameObject zombiePrefab;
    public GameObject powerUpPrefab;

    public float wait;

    public bool canSpawn = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InstantiateZombie());
        StartCoroutine(InstantiatePowerUp());
    }

    public IEnumerator InstantiateZombie()
    {
        canSpawn = true;
        while (canSpawn)
        {
            GameObject _zombie = Instantiate(zombiePrefab, new Vector3(Random.Range(-4, 4), 0, 85), Quaternion.Euler(0, 180, 0));
            yield return new WaitForSeconds(wait);

            wait = Mathf.Max(0.2f, wait - 0.1f);

            Mathf.Clamp(wait, 5, 0.5f);
        }
    }


    public IEnumerator InstantiatePowerUp()
    {
        while (canSpawn)
        {
            float _wait =  Random.Range(0, 5);

            GameObject _powerUp = Instantiate(powerUpPrefab, new Vector3(Random.Range(-4, 4), 0, 85), Quaternion.Euler(0, 180, 0));
            yield return new WaitForSeconds(_wait);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
