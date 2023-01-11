using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueLargoaBruja : MonoBehaviour
{
    public DañoaBrujaLargo dañoFuego;
    // Start is called before the first frame update
    void Start()
    {
        dañoFuego = FindObjectOfType<DañoaBrujaLargo>();
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
