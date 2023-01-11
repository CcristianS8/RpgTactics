using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoOgroLargo : MonoBehaviour
{

    public GameObject ataqueLargo;
    public GameObject particulasAgua;
    public ParticleSystem Agua;
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
        Agua.Play();
        particulasAgua.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        click = false;
        ataqueLargo.SetActive(false);
        particulasAgua.SetActive(false);
        Agua.Stop();


    }
}
