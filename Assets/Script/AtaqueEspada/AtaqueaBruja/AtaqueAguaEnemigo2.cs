using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueAguaEnemigo2 : MonoBehaviour
{
    public Da�oAguaEnemigo2 da�oAgua;
    // Start is called before the first frame update
    void Start()
    {
        da�oAgua = FindObjectOfType<Da�oAguaEnemigo2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            da�oAgua.click = true;
            Debug.Log("esta desntro");

        }

    }
}
