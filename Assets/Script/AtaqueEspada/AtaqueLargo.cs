using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueLargo : MonoBehaviour
{

    public DañoOgroLargo dañoAgua;
    // Start is called before the first frame update
    void Start()
    {
        dañoAgua = FindObjectOfType<DañoOgroLargo>();
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
