using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCaballeroFuego : MonoBehaviour
{

    public Da�oOgroFuego da�oFuego;
    // Start is called before the first frame update
    void Start()
    {
        da�oFuego = FindObjectOfType<Da�oOgroFuego>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            da�oFuego.click = true;
            Debug.Log("esta desntro");

        }

    }

}
