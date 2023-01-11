using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCaballero : MonoBehaviour
{


    public DañoOgro esclick;
    
   
    

    // Start is called before the first frame update
    void Start()
    {
        esclick = FindObjectOfType<DañoOgro>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            esclick.click = true;
            Debug.Log("esta desntro");

        }

    }

}
