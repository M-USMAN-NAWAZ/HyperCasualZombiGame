using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public GameObject dieFx;

    public void InitDirection(Vector3 dir)
    {
        direction = dir.normalized;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destroy") )
        {

            Destroy(this.gameObject);
        }

        if(other.CompareTag("Zombie"))
        {
            
            StartCoroutine(DestroyZombie(this.gameObject, other.gameObject));
        }
        
        if(other.CompareTag("PowerUpBox"))
        {
            other.GetComponent<PowerUp>().power -= 1;
            other.GetComponent<PowerUp>().powerText.text = other.GetComponent<PowerUp>().power.ToString();
        }
    }
    public IEnumerator DestroyZombie(GameObject _bullet, GameObject _zombie)
    {
        speed = 0f;
        dieFx.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Destroy(_bullet.gameObject);
        Destroy(_zombie.gameObject);
    }


    void Update()
    {
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
