using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueLargo : MonoBehaviour
{

    public Da�oOgroLargo da�oAgua;
    // Start is called before the first frame update
    void Start()
    {
        da�oAgua = FindObjectOfType<Da�oOgroLargo>();
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
