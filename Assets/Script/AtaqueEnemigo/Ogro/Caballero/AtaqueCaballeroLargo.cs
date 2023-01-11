using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCaballeroLargo : MonoBehaviour
{
    public DañoCaballeroLargo dañoMagicDark;

    // Start is called before the first frame update
    void Start()
    {
        dañoMagicDark = FindObjectOfType <DañoCaballeroLargo>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            dañoMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
