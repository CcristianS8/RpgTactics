using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueAguaEnemigo2 : MonoBehaviour
{
    public DaņoAguaEnemigo2 daņoAgua;
    // Start is called before the first frame update
    void Start()
    {
        daņoAgua = FindObjectOfType<DaņoAguaEnemigo2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ogro"))
        {

            daņoAgua.click = true;
            Debug.Log("esta desntro");

        }

    }
}
