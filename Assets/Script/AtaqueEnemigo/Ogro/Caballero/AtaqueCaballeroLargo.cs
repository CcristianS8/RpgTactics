using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCaballeroLargo : MonoBehaviour
{
    public Da�oCaballeroLargo da�oMagicDark;

    // Start is called before the first frame update
    void Start()
    {
        da�oMagicDark = FindObjectOfType <Da�oCaballeroLargo>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            da�oMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
