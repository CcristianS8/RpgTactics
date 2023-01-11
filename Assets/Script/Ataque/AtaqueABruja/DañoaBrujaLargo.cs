using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoaBrujaLargo : MonoBehaviour
{
   
    public GameObject ataqueLargo;
    public GameObject particulasFuego;
    public ParticleSystem Fuego;
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
            
            ataqueLargo.SetActive(false);
            click = false;
            StartCoroutine(electricidadPlay());
        }



    }

    IEnumerator electricidadPlay()
    {
        Fuego.Play();
        particulasFuego.SetActive(true);
        yield return new WaitForSeconds(2);
        particulasFuego.SetActive(false);
        Fuego.Stop();


    }
}
