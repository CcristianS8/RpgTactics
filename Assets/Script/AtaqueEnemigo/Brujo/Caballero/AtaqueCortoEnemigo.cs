using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCortoEnemigo : MonoBehaviour
{


    public Da�oPlayerCorto da�oMagicDark;
    public float mana = 90;

    // Start is called before the first frame update
    void Start()
    {
        da�oMagicDark = FindObjectOfType<Da�oPlayerCorto>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player" ) && mana >= 100)
        {

            da�oMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
