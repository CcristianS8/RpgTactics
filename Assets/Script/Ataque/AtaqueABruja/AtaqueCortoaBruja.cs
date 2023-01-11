using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCortoaBruja : MonoBehaviour
{
    public DañoCortoaBruja esclick;




    // Start is called before the first frame update
    void Start()
    {
        esclick = FindObjectOfType<DañoCortoaBruja>();

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
