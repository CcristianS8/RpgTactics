using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoOgro : MonoBehaviour
{

    public GameObject ataqueCorto;
    public GameObject particulasElectricidad;
    public ParticleSystem electricidad;
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
       
        if(click == true)
        {
            StartCoroutine(electricidadPlay());
        }
       
           

    }

    IEnumerator electricidadPlay()
    {
        electricidad.Play();
        particulasElectricidad.SetActive(true);
        yield return new WaitForSeconds(2);
        ataqueCorto.SetActive(false);
        click = false;
        particulasElectricidad.SetActive(false);
        electricidad.Stop();


    }
}
