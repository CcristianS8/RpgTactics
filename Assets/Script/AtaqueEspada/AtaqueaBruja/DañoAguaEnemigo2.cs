using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoAguaEnemigo2 : MonoBehaviour
{
    DañoESpadaEnemigo2 vida;
    public GameObject ataqueLargo;
    public GameObject particulasAgua;
    public ParticleSystem Agua;
    public bool click = false;
    // Start is called before the first frame update
    void Start()
    {
        vida = GetComponent<DañoESpadaEnemigo2>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {

        if (click == true)
        {
            vida.DañoAgua();
            click = false;
            ataqueLargo.SetActive(false);
            StartCoroutine(electricidadPlay());
        }



    }

    IEnumerator electricidadPlay()
    {
        Agua.Play();
        particulasAgua.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        particulasAgua.SetActive(false);
        Agua.Stop();


    }
}
