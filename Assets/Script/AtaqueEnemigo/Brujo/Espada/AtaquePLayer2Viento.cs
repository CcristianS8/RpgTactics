using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePLayer2Viento : MonoBehaviour
{
    public Da?oPlayerViento da?oMagicDark;

    // Start is called before the first frame update
    void Start()
    {
        da?oMagicDark = FindObjectOfType<Da?oPlayerViento>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {

            da?oMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
