using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePLayer2 : MonoBehaviour
{
    public DañoPLayer2 dañoMagicDark;
    public float mana = 90;

    // Start is called before the first frame update
    void Start()
    {
        dañoMagicDark = FindObjectOfType<DañoPLayer2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player2") && mana >= 100 )
        {

            dañoMagicDark.click = true;
            Debug.Log("esta desntro");

        }

    }
}
