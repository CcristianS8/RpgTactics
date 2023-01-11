using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspadaLargo : MonoBehaviour
{
    public DañoEspadaLargo dañoMagicDark;

    // Start is called before the first frame update
    void Start()
    {
        dañoMagicDark = FindObjectOfType<DañoEspadaLargo>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {

            dañoMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
