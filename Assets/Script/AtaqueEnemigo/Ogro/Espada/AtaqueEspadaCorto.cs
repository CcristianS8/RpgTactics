using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueEspadaCorto : MonoBehaviour
{
    public Da�oEspadaCorto da�oMagicDark;
    public float mana = 90;

    // Start is called before the first frame update
    void Start()
    {
        da�oMagicDark = FindObjectOfType<Da�oEspadaCorto>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2"))
        {

            da�oMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
