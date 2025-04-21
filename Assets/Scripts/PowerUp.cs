using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float power;

    public TMP_Text powerText;

    public GameObject idolBox;
    public GameObject destroiedBox;

    // Start is called before the first frame update
    void Start()
    {
        powerText.text = power.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(power < 0)
        {
            idolBox.SetActive(false);
            destroiedBox.SetActive(true);
        }
    }
}
