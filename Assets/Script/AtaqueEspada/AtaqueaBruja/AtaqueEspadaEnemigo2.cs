using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspadaEnemigo2 : MonoBehaviour
{
    public Da�oESpadaEnemigo2 da�oEspada;

    // Start is called before the first frame update
    void Start()
    {
        da�oEspada = FindObjectOfType<Da�oESpadaEnemigo2>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            da�oEspada.click = true;
            Debug.Log("esta desntro");

        }

    }
}
