using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCaballeroFuego : MonoBehaviour
{

    public DañoOgroFuego dañoFuego;
    // Start is called before the first frame update
    void Start()
    {
        dañoFuego = FindObjectOfType<DañoOgroFuego>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            dañoFuego.click = true;
            Debug.Log("esta desntro");

        }

    }

}
