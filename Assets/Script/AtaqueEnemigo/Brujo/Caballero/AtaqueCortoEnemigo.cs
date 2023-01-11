using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueCortoEnemigo : MonoBehaviour
{


    public DañoPlayerCorto dañoMagicDark;
    public float mana = 90;

    // Start is called before the first frame update
    void Start()
    {
        dañoMagicDark = FindObjectOfType<DañoPlayerCorto>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player" ) && mana >= 100)
        {

            dañoMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
