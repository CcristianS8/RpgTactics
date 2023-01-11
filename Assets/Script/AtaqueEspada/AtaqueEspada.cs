using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspada : MonoBehaviour
{
    public DanoOgro dañoEspada;
   
    // Start is called before the first frame update
    void Start()
    {
        dañoEspada = FindObjectOfType<DanoOgro>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            dañoEspada.click = true;
            Debug.Log("esta desntro");

        }

    }
}
