using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanoOgro : MonoBehaviour
{
    public GameObject ataqueCorto;
    public GameObject particulasEspada;
    public ParticleSystem espada;
    public bool click = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {

        if (click == true)
        {
            StartCoroutine(electricidadPlay());
        }



    }

    IEnumerator electricidadPlay()
    {
        espada.Play();
        ataqueCorto.SetActive(false);
        particulasEspada.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        click = false;
        particulasEspada.SetActive(false);
        espada.Stop();


    }
}
