using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueAguaEnemigo2 : MonoBehaviour
{
    public DañoAguaEnemigo2 dañoAgua;
    // Start is called before the first frame update
    void Start()
    {
        dañoAgua = FindObjectOfType<DañoAguaEnemigo2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            dañoAgua.click = true;
            Debug.Log("esta desntro");

        }

    }
}
