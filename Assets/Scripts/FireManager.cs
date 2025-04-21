using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireManager : MonoBehaviour
{
    public static FireManager Instance;

    public GameObject bullrtPrefab;
    public GameObject shootPoint;
    public GameObject destroywall;
    public GameObject playerHouse;

    public float Wait;

    public bool isfiring = false;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        isfiring = true;

        StartCoroutine(Shoot());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("X3"))
        {
            StartCoroutine(increaseSpeed());
        }
    }
    IEnumerator increaseSpeed()
    {
        Wait /= 3;
        yield return new WaitForSeconds(30);
    }

    public IEnumerator Shoot()
    {
        while (isfiring)
        {
            GameObject _bullet = Instantiate(bullrtPrefab, shootPoint.transform.position, Quaternion.identity);
            _bullet.GetComponent<Bullet>().InitDirection(shootPoint.transform.forward);
            yield return new WaitForSeconds(Wait);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
