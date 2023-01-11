using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DañoESpadaEnemigo2 : MonoBehaviour
{
    public GameObject ataqueCorto;
    public GameObject particulasEspada;
    public ParticleSystem espada;
    public bool click = false;
    public Image barraVIda;
    public float vida;
    public float vidaMaxima;
    public float dañoEsapada = 0.15F;
    public float dañoAgua = 0.25F;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        barraVIda.fillAmount = vida;
    }

    public void OnMouseDown()
    {

        if (click == true)
        {

            vida -= dañoEsapada;
            espada.Play();
            ataqueCorto.SetActive(false);
            StartCoroutine(electricidadPlay());
            click = false;
        }



    }

    IEnumerator electricidadPlay()
    {
       
        particulasEspada.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        particulasEspada.SetActive(false);
        espada.Stop();


    }

    public void DañoAgua()
    {
        vida -= dañoAgua;
    }

}
