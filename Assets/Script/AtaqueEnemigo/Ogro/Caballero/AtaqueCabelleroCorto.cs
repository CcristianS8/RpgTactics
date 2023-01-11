using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCabelleroCorto : MonoBehaviour
{
    public DañoCaballeroCorto dañoMagicDark;
    public float mana = 90;

    // Start is called before the first frame update
    void Start()
    {
        dañoMagicDark = FindObjectOfType<DañoCaballeroCorto>();
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
